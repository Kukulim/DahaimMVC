using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DahaimMVC.Areas.Shop.Models.OrdersModels
{
    public class Cart
    {
        [Key]
        [Column(Order = 0)]
        public int RecordId { get; set; }

        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public virtual Product Product { get; set; }
    }
}