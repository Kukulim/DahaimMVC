namespace DahaimMVC.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }

        [Required]
        [DisplayName("U�ytkownik:")]
        [StringLength(50)]
        public string UserName { get; set; }

        [DisplayName("Has�o:")]
        [DataType(DataType.Password)]
        [Required]
        [StringLength(50)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Za-z]).{5,}", ErrorMessage = "Has�o musi mie� przynajmniej 5 symboli z czego jeden musi by� liter� i jeden musi by� liczba")]
        public string UserPassword { get; set; }

        [DisplayName("Powt�rz_Has�o:")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [Compare("UserPassword")]
        public string ConfirmPassword { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Imi�:")]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Nazwisko:")]
        public string Subname { get; set; }

        [StringLength(50)]
        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email:")]
        public string Email { get; set; }

        [DisplayName("Numer_telefonu:")]
        [StringLength(12, MinimumLength = 8)]
        public string PhoneNumber { get; set; }

        public LanguageLvlEmun LanguageLvl { get; set; }
    }
}