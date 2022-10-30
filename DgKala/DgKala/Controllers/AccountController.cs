using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Claims;
using System.Threading.Tasks.Dataflow;
using DgKala.Convertors;
using DgKala.Generators;
using DgKala.Models.Context;
using DgKala.Models.Entities.User;
using DgKala.Models.ViewModels.AccountViewModel;
using DgKala.Repository;
using DgKala.Senders;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TopLearn.Core.Security;

namespace DgKala.Controllers
{
    public class AccountController : Controller
    {
        private IUserServices _userServices;

        private IViewRenderService _renderService;

        public AccountController(IUserServices userServices,IViewRenderService renderService)
        {
            _userServices = userServices;
            _renderService = renderService;
        }

        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
                return View(register);


            if (_userServices.IsExistsUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد ");
                return View(register);
            }

            if (_userServices.IsExistsEmail(FixText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتبر نمی باشد ");
                return View(register);
            }

            DgKala.Models.Entities.User.User user = new User()
            {
                ActiveCode = NameGenerator.GeneratorUniqCode(),
                Email = FixText.FixEmail(register.Email),
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                UserAvatar = "3.jpg",
                UserName = register.UserName,
                RegisterDate = DateTime.Now,

            };


            _userServices.AddUser(user);

            #region Send Activation Email

            string body = _renderService.RenderToStringAsync("_ActiveEmail",user);
       SendEmail.Send(user.Email,"فعالسازی ",body);

            #endregion

            return View("SuccessRegister", user);
        }
        #endregion
         

        #region Login

        [Route("Login")]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = _userServices.LoginUser(login);
            if (user!=null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                        new Claim(ClaimTypes.Name, user.UserName)


                    };
                    var identiti = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var prinsipal = new ClaimsPrincipal(identiti);
                    var propertis = new AuthenticationProperties()
                    {
                        IsPersistent = login.RememberMy
                    };
                    HttpContext.SignInAsync(prinsipal, propertis);

                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email","حساب کاربری شما فعال نمی باشد ");
                }

            }
            ModelState.AddModelError("Email","کاربری با مشخصات وارد شده یافت نشد ");

            return View(login);
        }

        #endregion

        #region ActiveAccount
    
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userServices.ActiveAccount(id);
            return View();
        }

        #endregion

        #region Logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }

        #endregion

        #region ForgotPassword
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        [Route("ForgotPassword")]

        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
   
                return View(forgot);


            string fixedEmail = FixText.FixEmail(forgot.Email);
            DgKala.Models.Entities.User.User user = _userServices.GetUserByEmail(fixedEmail);

            if (user==null)
            {
                ModelState.AddModelError("Email","حساب کاربری یافت نشد ");
                return View(forgot);
            }

            string BodyEmail = _renderService.RenderToStringAsync("_ForgotPassword",user);
            SendEmail.Send(user.Email,"بازیابی  حساب کاربری ",BodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }

        #endregion

        #region ResetPassword

        public IActionResult ResetPassword(string id)
        {
            return View(new  ResetPasswordViewModel()
            {
                ActiveCode = id
            });
        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
     
                return View();


            DgKala.Models.Entities.User.User user = _userServices.GetUserByActiveCode(reset.ActiveCode);
            if (user==null)
            {
                return NotFound();
            }

            string hashPassword = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hashPassword;
            _userServices.UpdateUser(user);
            return Redirect("/Login");
        }

        #endregion

}
}
