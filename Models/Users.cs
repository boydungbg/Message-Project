using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Email.Models
{
    public class Users
    {
        public int? UserID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string UserName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string PassWord { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public List<Message> ListMessage { get; set; }
        public Users()
        {

        }
        public Users(int? userID, string userName, string fullname, string passWord, string email, DateTime registerDate, List<Message> listMessage)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.FullName = fullname;
            this.PassWord = passWord;
            this.Email = email;
            this.RegisterDate = registerDate;
            this.ListMessage = listMessage;
        }
    }
}