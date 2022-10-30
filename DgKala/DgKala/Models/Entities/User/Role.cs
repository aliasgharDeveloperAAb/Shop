using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DgKala.Models.Entities.Permissions;

namespace DgKala.Models.Entities.User
{
    public class Role
    {
        public Role()
        {
            
        }
        [Key]
        public int RoleId { get; set; }
        [Display(Name = "نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{1} نمی تواند بیشتر از {0} کاراکتر داشته باشد")]
        public string RoleTitle { get; set; }
        
        public bool IsDelete { get; set; } 

        #region Relation

        public List<UserRole> UserRoles { get; set; }
        public List<RolePermission> RolePermissions { get; set; }

        #endregion
    }
}
