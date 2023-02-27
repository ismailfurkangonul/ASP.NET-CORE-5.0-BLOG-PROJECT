using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "Technology", categorycount = 25 });
            list.Add(new CategoryClass { categoryname = "Software", categorycount = 25});
            list.Add(new CategoryClass { categoryname = "Game", categorycount = 25 });
            list.Add(new CategoryClass { categoryname = "Cinema&Film", categorycount = 25 });
            return Json(new { jsonlist = list });
        }
    }
}
