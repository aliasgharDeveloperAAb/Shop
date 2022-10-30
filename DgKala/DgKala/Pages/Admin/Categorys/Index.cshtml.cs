using System.Collections.Generic;
using DgKala.Models.ViewModels.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Categorys
{
    public class IndexModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public IndexModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public List<ShowCategoryForAdminViewModel> ListCategory { get; set; } 
        public void OnGet()
        {
            ListCategory = _categoryServices.GetCategoryForAdmin();
        }
    }
}
