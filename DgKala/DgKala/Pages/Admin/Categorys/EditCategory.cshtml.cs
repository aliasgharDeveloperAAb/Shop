using System.Collections.Generic;
using DgKala.Models.Entities.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;

namespace DgKala.Pages.Admin.Categorys
{
    public class EditCategoryModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public EditCategoryModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [BindProperty]
        public Category Category { get; set; } 
        public void OnGet(int id)
        {
            Category = _categoryServices.GetCategoryById(id);
            var groups = _categoryServices.GetGroupForManageCategory();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text", Category.GroupId);
            List<SelectListItem> subgroups = new List<SelectListItem>()
            {
                new SelectListItem() {Text = "انتخاب کنید",Value = ""}
            };
      
            subgroups.AddRange(_categoryServices.GetSubGroupForManageCategory(Category.GroupId));
            string selectedSubGroup = null;
            if (Category.SubGroup != null)
            {
                selectedSubGroup = Category.SubGroup.ToString();
            }
           
        
            ViewData["SubGroups"] = new SelectList(subgroups, "Value", "Text",Category.SubGroup??0);

            var teachers = _categoryServices.GetTeacher();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text",Category.TeacherId);

            var statues = _categoryServices.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text",Category.StatuesId);
        }
        public IActionResult OnPost(IFormFile imgCategoryUp)
        {
            if (!ModelState.IsValid)
                return Page();

            _categoryServices.UpdateCategory(Category,imgCategoryUp);

            return RedirectToPage("Index");
        }
    }
}
