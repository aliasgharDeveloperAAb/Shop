using DgKala.Models.Entities.User;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Roles
{
    public class DeleteRoleModel : PageModel
    {
        private IPermissionServices _permissionServices;

        public DeleteRoleModel(IPermissionServices permissionServices)
        {
            _permissionServices = permissionServices;
        }
        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _permissionServices.GetRoleById(id);
        }
        public IActionResult OnPost()
        {
            _permissionServices.DeleteRole(Role);
            return RedirectToPage("Index");
        }
    }
}
