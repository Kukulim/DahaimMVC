using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Models
{
    [Bind(Exclude = "ProductId")]
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        [DisplayName("Typ")]
        public int TypeId { get; set; }
        [DisplayName("Autor")]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string Title { get; set; }
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [DisplayName("Produkt URL")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        public virtual Type Type { get; set; }
        public virtual Author Author { get; set; }
    }
}