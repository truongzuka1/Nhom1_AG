using Microsoft.AspNetCore.Mvc;

namespace Nhom1_AG.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Giao diện chính với layout
        }

        // Partial cho trang sản phẩm
        public IActionResult LoadProduct()
        {
            return PartialView("_ProductPartial"); // Trả về partial
        }

        // Partial cho giỏ hàng
        public IActionResult LoadCart()
        {
            return PartialView("_CartPartial");
        }

        // Partial cho đơn hàng
        public IActionResult LoadOrder()
        {
            return PartialView("_OrderPartial");
        }

        // Partial cho voucher
        public IActionResult LoadVoucher()
        {
            return PartialView("_VoucherPartial");
        }

        
    }
}
