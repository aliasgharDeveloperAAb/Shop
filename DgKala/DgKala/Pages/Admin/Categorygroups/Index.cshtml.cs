using System.Collections.Generic;
using DgKala.Models.Entities.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DgKala.Pages.Admin.Categorygroups
{
    public class IndexModel : PageModel
    {
        private ICategoryServices _categoryServices;

        public IndexModel(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public List<CategoryGroups> CategorygroupsList { get; set; }
        public void OnGet()
        {
            CategorygroupsList = _categoryServices.GetAllGroup();
        }
    }
}
