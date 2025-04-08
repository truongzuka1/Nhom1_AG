using Microsoft.AspNetCore.Mvc;
using Nhom1_AG.Models;
using Nhom1_AG.ViewModels;

namespace Nhom1_AG.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị form tạo đơn hàng mới
        public IActionResult CreateOrder()
        {
            return View(new OrderViewModel()); // Trả về một đối tượng ViewModel rỗng
        }

        // Xử lý khi người dùng gửi form
        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    UserId = model.UserId,
                    Status = model.Status
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(model); // Nếu dữ liệu không hợp lệ, quay lại form và giữ dữ liệu đã nhập
        }
    }

}
