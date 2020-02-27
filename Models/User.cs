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
        [DisplayName("User:")]
        [StringLength(50)]
        public string UserName { get; set; }

        [DisplayName("Password:")]
        [DataType(DataType.Password)]
        [StringLength(50)]
        [Required]
        public string UserPassword { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(50)]
        [Required]
        public string Subname { get; set; }
        [StringLength(50)]
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public LanguageLvlEmun LanguageLvl { get; set; }
    }
}
