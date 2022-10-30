using System.Threading.Tasks;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DgKala.ViewComponents
{
    public class CategoryGroupComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private ICategoryServices _category;

        public CategoryGroupComponent(ICategoryServices category)
        {
            _category = category;
        }


        public async Task<IViewComponentResult> InvokeAsync() 
        {
            return await Task.FromResult((IViewComponentResult) View("CategoryGroups",_category.GetAllGroup()));
        }
    }
}
