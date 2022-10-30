using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DgKala.Models.Entities.Category;
using DgKala.Repository;

namespace DgKala.Controllers
{ 
    public class CategoryController : Controller
    {
        private ICategoryServices _categoryServices;

        private IOrderServices _orderServices;

        private IUserServices _userServices;

        public CategoryController(ICategoryServices categoryServices,IOrderServices orderServices,IUserServices userServices)
        {
            _categoryServices = categoryServices;
            _orderServices = orderServices;
            _userServices = userServices;
        }
        public IActionResult Index(int pageId = 1, string filter = "", string getType = "all", string orderByType = "Exist", List<int> selectedGroups = null, int take = 0)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _categoryServices.GetAllGroup();
            ViewBag.pageId = pageId;


            return View(_categoryServices.GetCategory(pageId, filter, getType, orderByType, selectedGroups, 9));
        }
        [Route("ShowCategory/{id}")]

        public IActionResult ShowCategory(int id)
        {

            var category = _categoryServices.GetCategoryForShow(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        public ActionResult BuyCategory(int id)
        {
            int orderId = _orderServices.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrder/ShowOrder/" + orderId);
        }
        [HttpPost]
        public IActionResult CreateComment(CategoryComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userServices.GetUserIdByUsername(User.Identity.Name);
            _categoryServices.AddComment(comment);

            return View("ShowComment",_categoryServices.GetCategoryComment(comment.CategoryId));
        }
        public IActionResult ShowComment(int id,int pageId)
        {
           
            return View(_categoryServices.GetCategoryComment(id,pageId));
        }
     
    }
}
