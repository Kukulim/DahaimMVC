using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DahaimMVC.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Imię:")]
        public string MessageName { get; set; }

        [Required]
        [DisplayName("Email:")]
        public string MessageEmail { get; set; }

        [Required]
        [DisplayName("Wiadomość:")]
        public string MessageText { get; set; }

        public byte Readed { get; set; }
        public DateTime SendTime { get; set; }
    }
}