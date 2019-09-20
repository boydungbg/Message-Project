namespace Project_Email.Models
{
    public class Inbox
    {
        public int? InboxID { get; set; }
        public int MessageID { get; set; }
        public int ReceiverID { get; set; }
        public int IsDeleted { get; set; }
        public Message Message { get; set; }
        public Inbox() { }
        public Inbox(int? inboxID, int messageID, int receiverID, int isDeleted, Message message)
        {
            this.InboxID = inboxID;
            this.MessageID = messageID;
            this.ReceiverID = receiverID;
            this.IsDeleted = isDeleted;
            this.Message = message;
        }
    }
}