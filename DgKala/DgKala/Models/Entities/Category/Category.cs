using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DgKala.Models.Entities.Order;
using DgKala.Models.Entities.Quesion;

namespace DgKala.Models.Entities.Category
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public int GroupId { get; set; }
        public int? SubGroup { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int StatuesId { get; set; }

        [Display(Name = "عنوان محصول ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(450, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string CategoryTitle { get; set; }

        [Display(Name = "توضیحی در مورد  محصول")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "قیمت محصول")]

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CategoryPrice { get; set; }

        [MaxLength(700)]
        public string Tags { get; set; }
        [Display(Name = "رایگان!")]
        public bool IsFree { get; set; }
        [Display(Name = "ویژگی های محصول  ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(600, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string Attributes { get; set; }
        [MaxLength(500)]
        public string CategoryImageName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        #region Relation
        [ForeignKey("TeacherId")]
        public User.User User { get; set; }
        [ForeignKey("GroupId")]
        public CategoryGroups CategoryGroups { get; set; }
        [ForeignKey("SubGroup")]
        public CategoryGroups Groups { get; set; }


        public CategoryStatues CategoryStatues { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        public List<CategoryComment> CategoryComments { get; set; }

        public List<CategoryVote> CategoryVotes { get; set; }
        public List<Question> Questions { get; set; }
        #endregion


    }
}
