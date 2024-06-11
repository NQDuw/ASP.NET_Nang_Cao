using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        // hien thi dnah sach tat ca san pham
        public IActionResult Index()
        {
            var productList = _db.Products.ToList();
            return View(productList);
        }
        // hien thi dnah sach tat ca san pham co gia thap nhat
        //public IActionResult Index()
        //    {
        //        var productList = _db.Products.OrderBy(p=>p.Price).Take(5).ToList();
        //        return View(productList);
        //    }
        //    // hien thi dnah sach tat ca san pham co gia cao nhat
        //    public IActionResult Index()
        //    {
        //        var productList = _db.Products.OrderByDescending(p => p.Price).Take(5).ToList();
        //        return View(productList);
        //    }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
