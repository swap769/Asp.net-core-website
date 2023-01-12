using System.ComponentModel.DataAnnotations;

namespace website.Models.Account
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "Please Enter Your Email"), EmailAddress]
        [Required(ErrorMessage = "Please enter email"), DataType(DataType.EmailAddress),
            RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "please enter password"),
            RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",
            ErrorMessage = "Minimum 8 character with uparcase,lowercase alphabets,numbers and special symbols")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string? Address { get; set; }
    }
}
