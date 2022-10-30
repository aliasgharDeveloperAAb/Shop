using DgKala.Migrations;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DgKala.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class MyOrderController : Controller
    {
        
        private IOrderServices _orderServices;

        public MyOrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowOrder(int id)
        {
            var order = _orderServices.GetOrderForUserPanel(User.Identity.Name,id);
            if (order==null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
