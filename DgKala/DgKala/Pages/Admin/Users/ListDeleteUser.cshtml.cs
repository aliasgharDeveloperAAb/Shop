using DgKala.Models.ViewModels.AdminViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Users
{
    public class ListDeleteUserModel : PageModel
    {
        private IUserServices _userServices;

        public ListDeleteUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        public void OnGet(int pageId = 1, string filterUserName = "", string filterEmail = "")
        {
            UserForAdminViewModel = _userServices.GetDeleteUser(pageId, filterUserName, filterEmail);
        }
    }
}
