using DahaimMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DahaimMVC.Areas.Admin.Models
{
    public class SqlMessageData : IMessageData
    {
        private readonly MessageDbContext messageDb;

        public SqlMessageData(MessageDbContext messageDb)
        {
            this.messageDb = messageDb;
        }

        public void Add(Message message)
        {
            messageDb.Messages.Add(message);
            message.Readed = 0;
            message.SendTime = DateTime.Now;
            messageDb.SaveChanges();
        }

        public void Delete(Message message)
        {
            var MessageEdit = messageDb.Messages.Find(message.Id);
            messageDb.Messages.Remove(MessageEdit);
            messageDb.SaveChanges();
        }

        public Message Get(int id)
        {
            return messageDb.Messages.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Message> GetAll()
        {
            return messageDb.Messages.ToList();
        }

        public Message GetAndRead(int id)
        {
            var MessageEdit = messageDb.Messages.FirstOrDefault(m => m.Id == id);
            MessageEdit.Readed = 1;
            messageDb.SaveChanges();
            return MessageEdit;
        }

        public int UnReaded()
        {
            int wynik = messageDb.Messages.Where(m => m.Readed == 0).Count();
            return wynik;
        }
    }
}