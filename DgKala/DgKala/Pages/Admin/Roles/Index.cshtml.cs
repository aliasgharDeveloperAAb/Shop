using System.Collections.Generic;
using DgKala.Models.Entities.User;
using DgKala.Models.ViewModels.AdminViewModel;
using DgKala.Repository;
using DgKala.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Roles 
{
  
    public class IndexModel : PageModel
    {
        private IPermissionServices _permission;

        public IndexModel(IPermissionServices permission)
        {
            _permission = permission;
        }
        public List<Role> RolesList { get; set; } 
        public void OnGet()
        {
            RolesList = _permission.GerRoles();

        }
    }
}
