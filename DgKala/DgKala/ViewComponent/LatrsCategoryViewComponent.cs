using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DgKala.ViewComponent
{
    public class LatrsCategoryViewComponent:Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private ICategoryServices _category;

        public LatrsCategoryViewComponent(ICategoryServices category)
        {
            _category = category;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("LatrsCategory", _category.GetCategory().Item1));
        }
    }
}
