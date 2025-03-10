using System.ComponentModel.DataAnnotations;

namespace Asp.Net_Core_Portfolio.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
    }
}
