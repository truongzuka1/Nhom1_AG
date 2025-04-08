using Microsoft.AspNetCore.Mvc;
using Nhom1_AG.Models;

namespace Nhom1_AG.Controllers
{
    public class VoucherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VoucherController(ApplicationDbContext context) => _context = context;

        public IActionResult Index() => View(_context.Vouchers.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Voucher voucher)
        {
            _context.Vouchers.Add(voucher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var voucher = _context.Vouchers.Find(id);
            if (voucher != null)
            {
                _context.Vouchers.Remove(voucher);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
