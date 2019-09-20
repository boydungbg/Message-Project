using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Email.Models
{
    public class Message
    {
        public int? MessageID { get; set; }
        [Column(TypeName = "Text")]
        public string ListReceiver { get; set; }
        [Column(TypeName = "Text")]
        public string Title { get; set; }
        [Column(TypeName = "Text")]
        public string Content { get; set; }
        public int SenderID { get; set; }
        public Users Sender { get; set; }
        public DateTime SendTime { get; set; }
        public int StatusMessage { get; set; }
        public List<Inbox> ListInbox { get; set; }
        public List<Outbox> ListOutbox { get; set; }
        public Message() { }
        public Message(int? messageID, string listReceiver ,string title, string content, int senderID, Users sender, DateTime sendTime, int statusMessage, List<Inbox> listInbox, List<Outbox> listOutbox)
        {
            this.MessageID = messageID;
            this.ListReceiver = listReceiver;
            this.Title = title;
            this.Content = content;
            this.SenderID = senderID;
            this.Sender = sender;
            this.SendTime = sendTime;
            this.StatusMessage = statusMessage;
            this.ListInbox = listInbox;
            this.ListOutbox = listOutbox;
        }
    }
}