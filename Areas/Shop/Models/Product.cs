using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DahaimMVC.Areas.Shop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int TypeId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public Type Type { get; set; }
        public Author Author { get; set; }
    }
}