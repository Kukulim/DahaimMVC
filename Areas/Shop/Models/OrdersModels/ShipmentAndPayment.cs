using System;
using System.ComponentModel;

namespace DahaimMVC.Areas.Shop.Models.OrdersModels
{
    public class ShipmentAndPayment
    {
        public int ShipmentAndPaymentId { get; set; }

        [DisplayName("Numer zamowienia:")]
        public int OrderId { get; set; }

        [DisplayName("Zapłacone:")]
        public bool IsPayed { get; set; }

        public DateTime PayedTime { get; set; }

        [DisplayName("Wysłane:")]
        public bool IsSent { get; set; }

        public DateTime SentTime { get; set; }

        [DisplayName("Zakonczone:")]
        public bool IsComplete { get; set; }

        public virtual Order Order { get; set; }
    }
}