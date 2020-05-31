using System.ComponentModel.DataAnnotations;

namespace Musique.Web.Models
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "Adresse électronique")]
        public string Credential { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
    }
}