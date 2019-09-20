using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Email.Common;
using Project_Email.Model;
using Project_Email.Models;

namespace Project_Email.Controllers
{
    public class HomeController : Controller
    {
        private MyDbContext dbContext;

        public HomeController(MyDbContext context)
        {
            this.dbContext = context;
        }
        [Authentication]
        public IActionResult Index()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            return View();
        }
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
