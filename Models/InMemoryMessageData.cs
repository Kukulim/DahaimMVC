using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public class InMemoryMessageData : IMessageData
    {
        List<Message> messages;

        public InMemoryMessageData()
        {
            messages = new List<Message>();
        }
        public void Add(Message mes)
        {
            messages.Add(mes);
            mes.Id = messages.Max(r => r.Id) + 1;
            mes.Readed = 0;
            mes.SendTime = DateTime.Now;
        }

        public void Delete(Message mes)
        {
            messages.RemoveAll(r => r.Id == mes.Id);
        }

        public Message Get(int id)
        {
            return messages.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Message> GetAll()
        {
            return messages.OrderBy(r => r.SendTime);
        }
    }
}