using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DgKala.Models.Entities.Category
{
    public class CategoryStatues
    {
        [Key]
        public int StatuesId { get; set; }
        [MaxLength(150)]
        [Required]
        public string StatuesTitle { get; set; }


        #region Relation

        public List<Category> Categories { get; set; }

        #endregion
    }
}
