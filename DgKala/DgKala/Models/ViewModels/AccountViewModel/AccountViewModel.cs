using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace DgKala.Models.ViewModels.AccountViewModel
{
    #region Register

    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Password { get; set; }
        [Display(Name = "تکرارکلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Compare("Password")]
        public string RePassword { get; set; }

    }

    #endregion


    #region LoginViewModel

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Email { get; set; }
        [Display(Name = "کلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار  ")]
        public bool RememberMy { get; set; }

    }

    #endregion


    #region  ForgotPassword

    public class ForgotPasswordViewModel
    {
        public string UserName { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Email { get; set; }
    }

    #endregion

    #region ResetPassword

    public class ResetPasswordViewModel
    {
        public string ActiveCode { get; set; } 

        [Display(Name = "کلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Password { get; set; }
        [Display(Name = "تکرارکلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        [Compare("Password")]
        public string RePassword { get; set; }
    }

    #endregion
}
