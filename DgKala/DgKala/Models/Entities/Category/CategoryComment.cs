using System;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Category
{
    public class CategoryComment 
    {
        [Key]
        public int CommentId { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminReed { get; set; }

        #region Relation

        public Category Category { get; set; }
        public User.User User { get; set; } 

        #endregion

    }
}
