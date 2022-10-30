using DgKala.Models.Entities.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Categorygroups
{
    public class CreateGroupModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public CreateGroupModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [BindProperty]
        public CategoryGroups CategoryGroups { get; set; }
        public void OnGet(int? id)
        {
            CategoryGroups = new CategoryGroups()
            {
                ParentID = id
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _categoryServices.AddGroup(CategoryGroups);
            return RedirectToPage("Index");
        }
    }
}
