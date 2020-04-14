using DahaimMVC.Areas.Shop.Models.OrdersModels;
using System.Collections.Generic;

namespace DahaimMVC.Areas.Shop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int Id { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}