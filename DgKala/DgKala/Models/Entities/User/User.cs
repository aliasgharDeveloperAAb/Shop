using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DgKala.Models.Entities.Category;
using DgKala.Models.Entities.Quesion;
using DgKala.Models.Entities.Wallet;

namespace DgKala.Models.Entities.User
{
    public class User
    {
        public User()
        {
            
        }
        [Key]
        
        public int UserId { get; set; }
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
        [Display(Name = "آواتار")]
        public string UserAvatar { get; set; }
        [Display(Name = "کدفعالسازی")]
        public string ActiveCode { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }
        public bool IsDelete { get; set; } 



        #region Relation

        public List<UserRole> UserRoles { get; set; }
        public virtual List<Wallet.Wallet> Wallets { get; set; }
        public virtual List<Category.Category> Categories { get; set; }
        public virtual List<Order.Order> Orders { get; set; }
        public virtual List<Question> Questions { get; set; }
        public List<CategoryComment> CategoryComments { get; set; }

        public List<CategoryVote> CategoryVotes { get; set; }

        #endregion
    }
}
