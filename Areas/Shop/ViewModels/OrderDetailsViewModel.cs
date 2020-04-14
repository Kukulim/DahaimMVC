using DahaimMVC.Areas.Shop.Models.OrdersModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.ViewModels
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}