using System.ComponentModel.DataAnnotations;
using DgKala.Models.Entities.User;

namespace DgKala.Models.Entities.Permissions
{
    public class RolePermission
    {
        public RolePermission()
        {
            
        }
        [Key]
        public int RP_Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }


        #region Relation

        public Role Role { get; set; }
        public Permission Permission { get; set; } 


        #endregion
    }
}
