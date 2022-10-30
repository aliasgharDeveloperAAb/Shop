using System.Linq;
using DgKala.Models.Entities.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DgKala.Pages.Admin.Categorys
{
    public class CreateCategoryModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public CreateCategoryModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [BindProperty]
        public Category Category { get; set; }
       
        public void OnGet()
        {
            var groups = _categoryServices.GetGroupForManageCategory();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var subgroups = _categoryServices.GetSubGroupForManageCategory(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subgroups, "Value", "Text");

            var teachers = _categoryServices.GetTeacher();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

            var statues = _categoryServices.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text");

        }
        public IActionResult OnPost(IFormFile imgCategoryUp)
        {
            if (!ModelState.IsValid)
                return Page();


            _categoryServices.AddCategory(Category, imgCategoryUp);

            return RedirectToPage("Index");
        }
    }
}
