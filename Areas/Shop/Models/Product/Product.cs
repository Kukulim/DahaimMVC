using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DahaimMVC.Areas.Shop.Models
{
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
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Cena")]
        [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [DisplayName("Produkt URL")]
        [StringLength(1024)]
        public string ProductArtUrl { get; set; }
        public virtual Type Type { get; set; }
        public virtual Author Author { get; set; }
    }
}