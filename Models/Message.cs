using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageName { get; set; }
        public string MessageEmail { get; set; }
        public string MessageText { get; set; }
        public byte Readed { get; set; }
        public DateTime SendTime { get; set; }
    }
}