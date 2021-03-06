﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DahaimMVC.Models
{
    public class InMemoryMessageData : IMessageData
    {
        private readonly List<Message> messages;

        public InMemoryMessageData()
        {
            messages = new List<Message>();
        }

        public void Add(Message mes)
        {
            messages.Add(mes);
            mes.Id = messages.Max(m => m.Id) + 1;
            mes.Readed = 0;
            mes.SendTime = DateTime.Now;
        }

        public void Delete(Message mes)
        {
            messages.RemoveAll(m => m.Id == mes.Id);
        }

        public Message Get(int id)
        {
            return messages.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Message> GetAll()
        {
            return messages.OrderBy(m => m.SendTime);
        }

        public Message GetAndRead(int id)
        {
            Message mes = messages.FirstOrDefault(m => m.Id == id);
            mes.Readed = 1;
            return mes;
        }

        public int UnReaded()
        {
            int wynik = messages.Where(m => m.Readed == 0).Count();
            return wynik;
        }
    }
}