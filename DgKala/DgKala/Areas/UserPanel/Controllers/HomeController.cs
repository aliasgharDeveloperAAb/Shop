using DgKala.Models.ViewModels.InformationViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DgKala.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]

    public class HomeController : Controller
    {
        private IUserServices _userServices;
         
        public HomeController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public IActionResult Index()
        {
            return View(_userServices.GetUserInformation(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userServices.GetDateForEditProfileUser(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel editProfile)
        {
            if (!ModelState.IsValid)

            {
                return View(editProfile);
            }
            //Logout User
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);


            _userServices.EditProfile(User.Identity.Name, editProfile);

            return Redirect("/Logout?EditProfile=true");
        }

        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            string currentUserName = User.Identity.Name;
            if (!ModelState.IsValid)
            {
                return View(change);
            }

            if (!_userServices.CompareOldPassword(currentUserName, change.OldPassword))
            {
                ModelState.AddModelError("OldPassword", " کلمه عبور قبلی صحیح نمی باشد ");
                return View(change);
            }
            _userServices.ChangeUserPassword(currentUserName, change.Password);
            ViewBag.IsSuccess = true;
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}
