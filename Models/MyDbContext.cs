using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Project_Email.Models;

namespace Project_Email.Model
{
    public class MyDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Inbox> Inbox { get; set; }
        public DbSet<Outbox> Outbox { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=2412;database=MessageDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserID);
                entity.Property(e => e.UserName);
                entity.Property(e => e.FullName);
                entity.Property(e => e.Email);
                entity.Property(e => e.PassWord);
                entity.Property(e => e.RegisterDate);
            });
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(m => m.MessageID);
                entity.Property(m => m.ListReceiver);
                entity.Property(m => m.Title);
                entity.Property(m => m.Content);
                modelBuilder.Entity<Message>().HasOne<Users>(m => m.Sender).WithMany(u => u.ListMessage).HasForeignKey(e => e.SenderID);
                entity.Property(m => m.SendTime);
                entity.Property(m => m.StatusMessage);
            });
            modelBuilder.Entity<Inbox>(entity =>
            {
                entity.HasKey(ib => ib.InboxID);
                modelBuilder.Entity<Inbox>().HasOne<Message>(ib => ib.Message).WithMany(m => m.ListInbox).HasForeignKey(ib => ib.MessageID);
                entity.Property(ib => ib.ReceiverID);
                entity.Property(ib => ib.IsDeleted);
            });
            modelBuilder.Entity<Outbox>(entity =>
        {
            entity.HasKey(ob => ob.OutboxID);
            modelBuilder.Entity<Outbox>().HasOne<Message>(ob => ob.Message).WithMany(m => m.ListOutbox).HasForeignKey(ob => ob.MessageID);
            entity.Property(ob => ob.SenderId);
            entity.Property(ob => ob.IsDeleted);
        });
        }
    }
}