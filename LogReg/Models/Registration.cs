using System.ComponentModel.DataAnnotations;
namespace LogReg.Models
{
    public class Registration
    {
        [Required]
        [MinLength(4)]
        public string FirstName {get; set;}
        [Required]
        [MinLength(4)]
        public string LastName {get; set;}

        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(2)]
        public string Password {get; set;}

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword {get; set;}
    }
}