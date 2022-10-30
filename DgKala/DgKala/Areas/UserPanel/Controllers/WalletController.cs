using DgKala.Models.ViewModels.WalletViewModel;
using DgKala.Repository;
using Microsoft.AspNetCore.Mvc;


namespace DgKala.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class WalletController : Controller
    {
        private IUserServices _userServices;

        public WalletController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.listWallet = _userServices.GetWalletUser(User.Identity.Name);
            return View();
        }

        [Route("UserPanel/Wallet")]
        [HttpPost]
        public IActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.listWallet = _userServices.GetWalletUser(User.Identity.Name);
                return View();
            }

            int walletId = _userServices.ChargeWallet(User.Identity.Name,"شارژ حساب ",charge.Amount);

            #region onlinePayment 

            var payment = new ZarinpalSandbox.Payment(charge.Amount);
            var res = payment.PaymentRequest("شارژ کیف پول  ", "https://localhost:44386/OnlinePayment/" +walletId);

            if (res.Result.Status==100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion


            return null;
        }


    }
}
