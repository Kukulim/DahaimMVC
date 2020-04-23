using System.Collections.Generic;

namespace DahaimMVC.Models
{
    public interface IMessageData
    {
        IEnumerable<Message> GetAll();

        Message Get(int id);

        Message GetAndRead(int id);

        void Add(Message message);

        void Delete(Message message);

        int UnReaded();
    }
}