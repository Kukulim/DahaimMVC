using System.ComponentModel;

namespace DahaimMVC.Areas.Shop.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [DisplayName("Autor")]
        public string AuthorName { get; set; }
    }
}