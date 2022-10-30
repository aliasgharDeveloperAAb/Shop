using DgKala.Models.Entities.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Categorygroups
{
    public class EditGroupModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public EditGroupModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [BindProperty]
        public CategoryGroups CategoryGroups { get; set; }
        public void OnGet(int id)
        {
            CategoryGroups = _categoryServices.GetyById(id);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            _categoryServices.UpdateGroup(CategoryGroups);
            return RedirectToPage("Index");
        }
    }
}