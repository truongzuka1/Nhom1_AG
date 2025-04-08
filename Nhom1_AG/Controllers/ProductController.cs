using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nhom1_AG.Models;

namespace Nhom1_AG.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context) => _context = context;

        public IActionResult Index(string search, int? categoryId)
        {
            var products = _context.Shoes.AsQueryable();

            // Áp dụng bộ lọc tìm kiếm
            if (!string.IsNullOrEmpty(search))
                products = products.Where(p => p.Name.Contains(search));

            // Áp dụng bộ lọc theo danh mục
            if (categoryId.HasValue)
                products = products.Where(p => p.CategoryId == categoryId);

            // Truyền các tham số query vào view thông qua ViewData
            ViewData["Search"] = search;
            ViewData["CategoryId"] = categoryId;

            // Truyền danh sách danh mục vào ViewBag để lọc sản phẩm
            ViewBag.Categories = _context.Categories.ToList();

            return View(products.ToList());
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Create() => View();

        [HttpPost, Authorize(Roles = "Admin")]
        public IActionResult Create(Shoe shoe)
        {
            if (!ModelState.IsValid) return View(shoe);

            _context.Shoes.Add(shoe);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
