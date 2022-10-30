using DgKala.Models.Entities.User;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DgKala.Pages.Admin.Roles
{
    public class EditRoleModel : PageModel
    {
        private IPermissionServices _permmiServices;

        public EditRoleModel(IPermissionServices permmiServices)
        {
            _permmiServices = permmiServices;
        }
        [BindProperty]
        public Role Role { get; set; } 
        public void OnGet(int id)
        {
            Role = _permmiServices.GetRoleById(id);
            ViewData["Permissions"] = _permmiServices.GetAllPermission();
            ViewData["SelectedPermission"] = _permmiServices.PermissionsRole(id);
        }
        public IActionResult OnPost(List<int> SelectPermission)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _permmiServices.UpdateRole(Role);

           _permmiServices.UpdatePermissionRole(Role.RoleId,SelectPermission);

            return RedirectToPage("Index");
        }
    } 
}
