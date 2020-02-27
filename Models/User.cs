namespace DahaimMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int UserId { get; set; }
        [Required]
        [DisplayName("U¿ytkownik:")]
        [StringLength(50)]
        public string UserName { get; set; }

        [DisplayName("Has³o:")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [Required]
        public string UserPassword { get; set; }
        [DisplayName("Powtórz_Has³o:")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [Compare("UserPassword")]
        public string ConfirmPassword { get; set; }
        [StringLength(50)]
        [Required]
        [DisplayName("Imiê:")]
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
        public string PhoneNumber { get; set; }

        public LanguageLvlEmun LanguageLvl { get; set; }
    }
}
