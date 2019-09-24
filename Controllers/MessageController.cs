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
    [Authentication]
    public class MessageController : Controller
    {
        private MyDbContext dbContext;
        public MessageController(MyDbContext context)
        {
            this.dbContext = context;
        }

        public IActionResult EmailDetailInbox(int messageID)
        {
            if (messageID == 0 || messageID.ToString() == null)
            {
                return Redirect("/Message/Inbox");
            }
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ManagerMessage managerMessage = new ManagerMessage(dbContext);
            ViewBag.count = managerMessage.GetCountMessageStatus(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            ViewBag.MessageDetail = managerMessage.GetMessageDetail(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value, messageID);
            if (ViewBag.MessageDetail == null)
            {
                return Redirect("/Message/Inbox");
            }
            return View();
        }

        public IActionResult Compose()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ManagerMessage managerMessage = new ManagerMessage(dbContext);
            ViewBag.count = managerMessage.GetCountMessageStatus(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }

        public IActionResult Outbox()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ManagerMessage managerMessage = new ManagerMessage(dbContext);
            ViewBag.listOutbox = managerMessage.GetListMessageOutbox(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            managerMessage = new ManagerMessage(dbContext);
            ViewBag.count = managerMessage.GetCountMessageStatus(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }

        public IActionResult Inbox()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ManagerMessage managerMessage = new ManagerMessage(dbContext);
            ViewBag.listInbox = managerMessage.GetListMessageInbox(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            ViewBag.count = managerMessage.GetCountMessageStatus(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }

        public IActionResult Trashcan()
        {
            var userid = HttpContext.Session.GetInt32("userId");
            ViewBag.user = dbContext.Users.FirstOrDefault(u => u.UserID == userid).FullName;
            ManagerMessage managerMessage = new ManagerMessage(dbContext);
            ViewBag.listTrashcan = managerMessage.GetListMessageTrashcan(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            ViewBag.count = managerMessage.GetCountMessageStatus(dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value);
            return View();
        }

        [HttpPost]
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
                Message message = new Message(null, receiver, title, content, senderID, null, DateTime.Now, null, null);
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
                    Inbox inbox = new Inbox(null, messageID, UserReciver.UserID.Value, 0, 0, null);
                    dbContext.Inbox.Add(inbox);
                    dbContext.SaveChanges();
                }
                Outbox outbox = new Outbox(null, messageID, senderID, 0, null);
                dbContext.Outbox.Add(outbox);
                dbContext.SaveChanges();
            }
            return Redirect("/Message/Compose");
        }
        public IActionResult DeleteMessageInbox(int MessageID)
        {
            if (MessageID != 0 || MessageID.ToString() != null)
            {
                var userid = HttpContext.Session.GetInt32("userId");
                int ReceiverID = dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value;
                Inbox inbox = dbContext.Inbox.LastOrDefault(i => i.MessageID == MessageID && i.ReceiverID == ReceiverID);
                if (inbox != null)
                {
                    inbox.IsDeleted = 1;
                    dbContext.SaveChanges();
                }
                Outbox outbox = dbContext.Outbox.LastOrDefault(i => i.MessageID == MessageID && i.SenderId == ReceiverID);
                if (outbox != null)
                {
                    outbox.IsDeleted = 1;
                    dbContext.SaveChanges();
                }
            }
            return Redirect("/Message/Inbox");
        }
        public IActionResult DeleteMessageOutbox(int MessageID)
        {
            if (MessageID != 0 || MessageID.ToString() != null)
            {
                var userid = HttpContext.Session.GetInt32("userId");
                int senderID = dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value;
                Outbox outbox = dbContext.Outbox.LastOrDefault(i => i.MessageID == MessageID && i.SenderId == senderID);
                if (outbox != null)
                {
                    outbox.IsDeleted = 1;
                    dbContext.SaveChanges();
                }
                Inbox inbox = dbContext.Inbox.LastOrDefault(i => i.MessageID == MessageID && i.ReceiverID == senderID);
                if (inbox != null)
                {
                    inbox.IsDeleted = 1;
                    dbContext.SaveChanges();
                }
            }
            return Redirect("/Message/Outbox");
        }

        public IActionResult UpdateStatusMessage(int messageID)
        {
            if (messageID != 0 || messageID.ToString() != null)
            {
                var userid = HttpContext.Session.GetInt32("userId");
                int userID = dbContext.Users.FirstOrDefault(u => u.UserID == userid).UserID.Value;
                Inbox inbox = dbContext.Inbox.FirstOrDefault(i => i.MessageID == messageID && i.ReceiverID == userID);
                if (inbox != null)
                {
                    inbox.StatusMessage = 1;
                    dbContext.SaveChanges();
                }
            }
            return Redirect("/Message/EmailDetailInbox?messageID=" + messageID + "");
        }
    }
}