using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [StringLength(160)]
        [DisplayName("Tytuł")]
        public string Title { get; set; }
        [DisplayName("Cena")]
        public decimal Price { get; set; }
        [DisplayName("Produkt URL")]
        [StringLength(1024)]
        public string ProductArtUrl { get; set; }
        public virtual Type Type { get; set; }
        public virtual Author Author { get; set; }
    }
}