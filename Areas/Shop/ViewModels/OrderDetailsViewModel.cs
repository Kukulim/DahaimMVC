using DahaimMVC.Areas.Shop.Models.OrdersModels;
using System.Collections.Generic;

namespace DahaimMVC.Areas.Shop.ViewModels
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}