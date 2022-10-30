using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DgKala.Models.Entities.Category
{
    public class CategoryGroups
    {
        [Key]
        public int GroupId { get; set; }
        [Display(Name = "عنوان گروه ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string GroupTitle { get; set; }
        [Display(Name = "گروه اصلی  ")]
        public int? ParentID { get; set; }
        [Display(Name = "حذف شده ؟  ")]
        public bool IsDelete { get; set; }

        [ForeignKey("ParentID")]
        public List<CategoryGroups> CategoryGroupsList { get; set; }
        [InverseProperty("CategoryGroups")]
        public List<Category> Categories { get; set; }
        [InverseProperty("Groups")]
        public List<Category> SubGroup { get; set; } 
        
     
        

    }
}
