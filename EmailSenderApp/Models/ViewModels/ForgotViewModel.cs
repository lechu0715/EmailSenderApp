using System.ComponentModel.DataAnnotations;

namespace EmailSenderApp.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
