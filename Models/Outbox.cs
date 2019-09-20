namespace Project_Email.Models
{
    public class Outbox
    {
        public int? OutboxID { get; set; }
        public int MessageID { get; set; }
        public int SenderId { get; set; }
        public int? IsDeleted { get; set; }
        public Message Message { get; set; }
        public Outbox() { }
        public Outbox(int? outboxID, int messageID, int senderId, int isDeleted, Message message)
        {
            this.OutboxID = outboxID;
            this.MessageID = messageID;
            this.SenderId = senderId;
            this.IsDeleted = isDeleted;
            this.Message = message;
        }
    }
}