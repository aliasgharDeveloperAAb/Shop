using System.Collections.Generic;
using DgKala.Models.Entities.User;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Roles
{
    public class CreateRoleModel : PageModel
    {
        private IPermissionServices _permissionServices;

        public CreateRoleModel(IPermissionServices permissionServices)
        {
            _permissionServices = permissionServices;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet()
        {
            ViewData["Permissions"] = _permissionServices.GetAllPermission();
        }
        public IActionResult OnPost(List<int> SelectPermission)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Role.IsDelete = false;
            int roleId = _permissionServices.AddRole(Role);


           _permissionServices.AddPermissionToRole(roleId,SelectPermission);

            return RedirectToPage("Index");
        }
    }
}
