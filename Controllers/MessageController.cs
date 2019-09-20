using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_Email.Common;
using Project_Email.Model;
using Project_Email.Models;

namespace Project_Email.Controllers
{
    public class MessageController : Controller
    {
        private MyDbContext dbContext;
        public MessageController(MyDbContext context)
        {
            this.dbContext = context;
        }
        [Authentication]
        public IActionResult Compose()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            return View();
        }
        [Authentication]
        public IActionResult Outbox()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ViewBag.listOutbox = GetListMessageOutbox(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }
        [Authentication]
        public IActionResult Inbox()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ViewBag.listInbox = GetListMessageInbox(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }
        [Authentication]
        public IActionResult SendMessage(string receiver, string title, string content)
        {
            var userid = HttpContext.Session.GetInt32("userId");
            int senderID = dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value;
            string[] Listreceivers;
            if (receiver != null && title != null && content != null)
            {
                Listreceivers = receiver.Split(",");
                foreach (var item in Listreceivers)
                {
                    if (item != "")
                    {
                        var UserReciver = dbContext.Users.FirstOrDefault(u => u.Email == item);
                        if (UserReciver == null)
                        {
                            return Redirect("/Message/Compose");
                        }
                    }
                }
                Message message = new Message(null, receiver, title, content, senderID, null, DateTime.Now, 0, null, null);
                dbContext.Message.Add(message);
                dbContext.SaveChanges();
                int messageID = dbContext.Message.Count();
                foreach (var item in Listreceivers)
                {
                    var UserReciver = dbContext.Users.FirstOrDefault(u => u.Email == item);
                    if (UserReciver == null)
                    {
                        return Redirect("/Message/Compose");
                    }
                    Inbox inbox = new Inbox(null, messageID, UserReciver.UserID.Value, 0, null);
                    dbContext.Inbox.Add(inbox);
                    dbContext.SaveChanges();
                }
                Outbox outbox = new Outbox(null, messageID, senderID, 0, null);
                dbContext.Outbox.Add(outbox);
                dbContext.SaveChanges();
            }
            return Redirect("/Message/Compose");
        }
        public List<Message> GetListMessageOutbox(int senderID)
        {
            Users users = new Users();
            users.ListMessage = dbContext.Message.FromSql("Select * from Message where SenderID = '" + senderID + "';").ToList();
            return users.ListMessage;
        }
        public List<Message> GetListMessageInbox(int ReceiverID)
        {
            Users users = new Users();
            users.ListMessage = dbContext.Message.FromSql("SELECT m.MessageID,m.ListReceiver,m.Title,m.Content,m.SendTime,m.SenderID,m.StatusMessage FROM inbox AS i INNER JOIN message AS m ON i.MessageID = m.MessageID where i.ReceiverID = '" + ReceiverID + "';").ToList();
            return users.ListMessage;
        }
    }
}