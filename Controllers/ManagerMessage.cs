using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project_Email.Model;
using Project_Email.Models;

namespace Project_Email.Controllers
{
    public class ManagerMessage
    {
        private MyDbContext dbContext;
        public ManagerMessage(MyDbContext context)
        {
            this.dbContext = context;
        }
        public List<Outbox> GetListMessageOutbox(int senderID)
        {
            List<Outbox> ListOutbox = new List<Outbox>();
            ListOutbox = dbContext.Outbox.Where(m => m.SenderId == senderID && m.IsDeleted == 0).ToList();
            foreach (var item in ListOutbox)
            {
                item.Message = dbContext.Message.FirstOrDefault(m => m.MessageID == item.MessageID);
                item.Message.Sender = dbContext.Users.FirstOrDefault(u => u.UserID == item.Message.SenderID);
            }
            return ListOutbox;
        }
        public List<Inbox> GetListMessageInbox(int ReceiverID)
        {
            List<Inbox> ListInbox = dbContext.Inbox.Where(i => i.ReceiverID == ReceiverID && i.IsDeleted == 0).ToList();
            foreach (var item in ListInbox)
            {
                item.Message = dbContext.Message.FirstOrDefault(m => m.MessageID == item.MessageID);
                item.Message.Sender = dbContext.Users.FirstOrDefault(u => u.UserID == item.Message.SenderID);
            }
            return ListInbox;
        }
        public List<Message> GetListMessageTrashcan(int UserID)
        {
            List<Message> ListMessages1 = new List<Message>();
            List<Message> ListMessages = new List<Message>();
            var ListInbox = dbContext.Inbox.Where(i => i.ReceiverID == UserID && i.IsDeleted == 1).ToList();
            foreach (var item in ListInbox)
            {
                item.Message = dbContext.Message.FirstOrDefault(m => m.MessageID == item.MessageID);
                ListMessages1.Add(item.Message);
            }
            var ListOutbox = dbContext.Outbox.Where(o => o.SenderId == UserID && o.IsDeleted == 1).ToList();
            foreach (var item in ListOutbox)
            {
                item.Message = dbContext.Message.FirstOrDefault(m => m.MessageID == item.MessageID);
                ListMessages.Add(item.Message);
            }
            foreach (var outbox in ListMessages)
            {
                outbox.Sender = dbContext.Users.FirstOrDefault(u => u.UserID == outbox.SenderID);
                outbox.Sender.FullName = "Tôi";
            }
            foreach (var inbox in ListMessages1)
            {
                inbox.Sender = dbContext.Users.FirstOrDefault(u => u.UserID == inbox.SenderID);
                if (dbContext.Outbox.FirstOrDefault(i => i.MessageID == inbox.MessageID && i.SenderId == inbox.SenderID) != null)
                {
                    ListMessages.Add(inbox);
                }
            }
            return ListMessages;
        }
        public int GetCountMessageStatus(int UserID)
        {
            int count = 0;
            List<Inbox> ListInbox = dbContext.Inbox.Where(i => i.ReceiverID == UserID && i.IsDeleted == 0 && i.StatusMessage == 0).ToList();
            foreach (var item in ListInbox)
            {
                count++;
            }
            ListInbox = null;
            return count;
        }
        public Message GetMessageDetail(int UserID, int messageID)
        {
            Inbox inboxMessage = null;
            inboxMessage = dbContext.Inbox.FirstOrDefault(i => i.MessageID == messageID && i.ReceiverID == UserID);
            if (inboxMessage == null)
            {
                return null;
            }
            inboxMessage.Message = dbContext.Message.FirstOrDefault(m => m.MessageID == inboxMessage.MessageID);
            inboxMessage.Message.Sender = dbContext.Users.FirstOrDefault(u => u.UserID == inboxMessage.Message.SenderID);
            return inboxMessage.Message;
        }
    }
}