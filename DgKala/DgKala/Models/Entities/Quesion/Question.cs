using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Quesion
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int UserId { get; set; }

        [Display(Name = "عنوان سوال")]
        [Required(ErrorMessage = "عنوان سوال را وارد کنید ")]
        [MaxLength(400)]
        public string Title { get; set; }

        [Display(Name = "متن سوال")]
        [Required(ErrorMessage = "متن سوال را وارد کنید ")]
        [MaxLength(4000)]
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }


        #region Relation

        public User.User User { get; set; }
        public Category.Category Category { get; set; }

        public List<Answer> Answers { get; set; }
        #endregion

    }
}
