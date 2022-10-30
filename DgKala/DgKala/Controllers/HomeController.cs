using DgKala.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DgKala.Models.Entities.Wallet;
using DgKala.Models.ViewModels.Category;
using DgKala.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DgKala.Controllers
{

    public class HomeController : Controller
    {
        private IUserServices _userServices;



        private readonly ILogger<HomeController> _logger;

        private ICategoryServices _category;

        public HomeController(IUserServices userServices, ILogger<HomeController> logger, ICategoryServices category)
        {
            _userServices = userServices;
            _logger = logger;
            _category = category;
        }

        public IActionResult Index()
        {

            return View(_category.GetCategory().Item1);
        }


        [Route("OnlinePayment/{id}")]
        public IActionResult OnlinePayment(int id)
        {
            if (HttpContext.Request.Query["Status"] != ""
                && HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];
                var wallet = _userServices.GetWalletByWalletId(id);
                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userServices.UpdateWallet(wallet);
                }
            }

            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        //public IActionResult GetSubGroups(int id)
        //{
        //    List<SelectListItem> list = new List<SelectListItem>()
        //    {
        //        new SelectListItem() {Text = "انتخاب کنید ",Value = ""}
        //    };
        //    list.AddRange(_category.GetSubGroupForManageCategory(id));
        //    return Json(new SelectList(list, "Value", "Text"));
        //}
        //[HttpPost]
        //[Route("file-upload")]
        //public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        //{
        //    if (upload.Length <= 0) return null;

        //    var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



        //    var path = Path.Combine(
        //        Directory.GetCurrentDirectory(), "wwwroot/MyImages",
        //        fileName);

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        upload.CopyTo(stream);

        //    }



        //    var url = $"{"/MyImages/"}{fileName}";


        //    return Json(new { uploaded = true, url });
        //}
    }

}


