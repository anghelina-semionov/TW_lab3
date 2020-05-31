using System.ComponentModel.DataAnnotations;

namespace Musique.Web.Models
{
    public class UserRegister
    {
        [Required]
        [Display(Name = "Nom complet")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Username cannot be longer than 30 characters.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Mot de passe")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password cannot be shorter than 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Adresse électronique")]
        [StringLength(30)]
        public string Email { get; set; }
    }
}