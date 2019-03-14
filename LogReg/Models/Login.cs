using System.ComponentModel.DataAnnotations;
namespace LogReg.Models
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(2)]
        public string Password {get; set;}

    }
}