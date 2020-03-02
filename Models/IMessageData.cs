using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahaimMVC.Models
{
    public interface IMessageData
    {
        IEnumerable<Message> GetAll();
        Message Get(int id);
        void Add(Message user);
        void Delete(Message user);
    }
}
