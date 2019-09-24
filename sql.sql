use messagedb;
select * from message;
select * from outbox;
select * from inbox;
select * from users;
select u.Email,m.MessageID,m.ListReceiver,m.Title,m.Content,m.SendTime,m.SendTime from users u inner join message m on u.userID = m.senderID inner join inbox i on m.messageID = i.messageID where i.ReceiverID =1;
drop database messagedb;