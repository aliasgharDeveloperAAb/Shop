using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Wallet
{
    public class Wallet
    {
        public Wallet()
        {
            
        }
        [Key]
        public int WalletId { get; set; }
        [Display(Name = "نوع تراکنش ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public int TypeId { get; set; }
        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public int UserId { get; set; }
        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Amount { get; set; }
        [Display(Name = "شرح")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Description { get; set; }
        [Display(Name = "تایید شده")]
        public bool IsPay { get; set; }
        [Display(Name = "تاریخ وساعت ")]
        public DateTime CreateDate { get; set; }


        #region Relation

        public virtual User.User User { get; set; }
        public virtual WalletType WalletType { get; set; }

        #endregion

    }
}
