using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa01
{
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BanThan()
        {
            return View();
        }
        public IActionResult ChaMe()
        {
            return View();
        }
        public IActionResult AnhChiEm()
        {
            return View();
        }
    }
}
