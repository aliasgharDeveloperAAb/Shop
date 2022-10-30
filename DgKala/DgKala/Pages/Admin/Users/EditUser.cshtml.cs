using System.Collections.Generic;
using DgKala.Models.ViewModels.AdminViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Users
{
    public class EditUserModel : PageModel
    {
        private IUserServices _userServices;

        private IPermissionServices _permissionServices;

        public EditUserModel(IUserServices userServices,IPermissionServices permissionServices)
        {
            _userServices = userServices;
            _permissionServices = permissionServices;
        }
        [BindProperty] 
        public EditUserViewModel EditUserViewModel { get; set; }
        public void OnGet(int id)
        {
            EditUserViewModel = _userServices.GetUserForShowEditModel(id);
            ViewData["Roles"] = _permissionServices.GerRoles();
        }
        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userServices.EditUserForAdmin(EditUserViewModel);
            // Edit Roles
            _permissionServices.EditRolesUser(EditUserViewModel.UserId,SelectedRoles);

            return RedirectToPage("Index");
        }
    }
}
