using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Models.OrdersModels
{
    [Bind(Exclude = "OrderId")]
    public class Order
    {
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        [DisplayName("Imię:")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [DisplayName("Nazwisko:")]
        [StringLength(160)]
        public string LastName { get; set; }

        [DisplayName("Adres:")]
        [Required(ErrorMessage = "Adres jest wymagany")]
        [StringLength(70)]
        public string Address { get; set; }

        [DisplayName("Miasto:")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [StringLength(40)]
        public string City { get; set; }

        [DisplayName("Województwo:")]
        [Required(ErrorMessage = "Województwo jest wymagane")]
        [StringLength(40)]
        public string State { get; set; }


        [Required(ErrorMessage = "Kod pocztowy jest wymagany")]
        [DisplayName("Kod pocztowy:")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [DisplayName("Kraj:")]
        [Required(ErrorMessage = "Kraj jest wymagany")]
        [StringLength(40)]
        public string Country { get; set; }

        [DisplayName("Telefon:")]
        [Required(ErrorMessage = "Telefon jest wymagany")]
        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [DisplayName("Email:")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email nie spełnia wymogów")]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}