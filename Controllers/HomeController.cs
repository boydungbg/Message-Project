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
    [Authentication]
    public class HomeController : Controller
    {
        private MyDbContext dbContext;

        public HomeController(MyDbContext context)
        {
            this.dbContext = context;
        }
        public IActionResult Index()
        {
            return Redirect("/Message/Inbox");
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
