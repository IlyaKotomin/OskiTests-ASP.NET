using System.ComponentModel.DataAnnotations;

namespace OskiTests.Models
{
    public class LoginViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
