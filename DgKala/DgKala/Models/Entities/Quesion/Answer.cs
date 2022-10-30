using System;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Quesion
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public Question Question { get; set; }
        public int UserId { get; set; }
        public User.User User { get; set; }
        [Required]
        public string BodyAnswer { get; set; }
        public bool IsTrue { get; set; } = false;
        public DateTime CreateDate { get; set; } 



    }
}
