using System;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Category
{
    public class CategoryVote
    {
        [Key]
        public int VodeId { get; set; }
        [Required]
        public int CategoryId { get; set; } 
        [Required]
        public int UserId { get; set; }
        [Required]
        public bool Vode { get; set; }

        public DateTime VodeDate { get; set; } = DateTime.Now;


        #region Relation

        public User.User User { get; set; }
        public Category Category { get; set; } 

        #endregion
    }
}
