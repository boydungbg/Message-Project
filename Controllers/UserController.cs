using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Email.Model;
using Project_Email.Models;

namespace Project_Email.Controllers
{
    public class UserController : Controller
    {
        private MyDbContext dbContext;
        public UserController(MyDbContext context)
        {
            dbContext = context;
            context.Database.EnsureCreated();
        }
        public IActionResult Login(bool error)
        {
            ViewBag.error = error;
            return View();
        }
        [HttpPost]
        public IActionResult Dologin(string name, string pass)
        {
            Users user = new Users();
            user = dbContext.Users.FirstOrDefault(us => us.UserName == name && us.PassWord == pass);
            if (user != null)
            {
                if (user.UserName == name && user.PassWord == pass)
                {
                    HttpContext.Session.SetInt32("userId", user.UserID.Value);
                    return Redirect("/Message/Inbox");
                }
            }
            return Redirect("/User/Login/?error=true");
        }
        public IActionResult Logout(string name)
        {
            HttpContext.Session.Clear();
            return Redirect("/User/Login");
        }
        public IActionResult Register(bool error)
        {
            ViewBag.error = error;
            return View();
        }
        [HttpPost]
        public IActionResult CreateACC(string name, string fullname, string email, string pass, string confirmpass)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.UserName == name || u.Email == email);
            if (user == null)
            {
                user = new Users(null, name, fullname, pass, email, DateTime.Now, null);
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return Redirect("/User/Login/");
            }
            return Redirect("/User/Register/?error=true");
        }
    }
}