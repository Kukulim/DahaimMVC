using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models.OrdersModels
{
    public class ShipmentAndPayment
    {
        public int ShipmentAndPaymentId { get; set; }
        public int OrderId { get; set; }
        public bool IsPayed { get; set; }
        public DateTime PayedTime { get; set; }
        public bool IsSent { get; set; }
        public DateTime SentTime { get; set; }
        public bool IsComplete { get; set; }
        public virtual Order Order { get; set; }
    }
}