using System.Collections.Generic;
using DgKala.Models.ViewModels.AdminViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Users
{
    public class CreateUserModel : PageModel
    {
        private IUserServices _userServices;

        private IPermissionServices _permission;

        public CreateUserModel(IUserServices userServices,IPermissionServices permission)
        {
            _userServices = userServices;
            _permission = permission;
        }
         
        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _permission.GerRoles();
        }

        public IActionResult OnPost(List<int>SelectedRoles)
        {
            if (!ModelState.IsValid)
                return Page();


            int userId = _userServices.AddUserFromAdmin(CreateUserViewModel);

            //Add Roles
            _permission.AddRolesToUser(SelectedRoles,userId);


            return Redirect("/Admin/Users");
        }
    }
}
