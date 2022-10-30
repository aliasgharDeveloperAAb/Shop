using DgKala.Models.ViewModels.InformationViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Users
{
    public class DeleteUserModel : PageModel
    {
        private IUserServices _userServices;

        public DeleteUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public InformationViewModel InformationViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserId"] = id;
            InformationViewModel = _userServices.GetUserInformation(id);
        }
        public IActionResult OnPost(int userId)
        {
            _userServices.DeleteUser(userId);
            return RedirectToPage("Index");
        }
    }
}
