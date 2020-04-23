using System.ComponentModel.DataAnnotations;

namespace DahaimMVC.Areas.Admin
{
    public class Administrator
    {
        public Administrator()
        {
            AdminName = "admin";
            AdminPassword = "admin";
        }

        [Required]
        public string AdminName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }
    }
}