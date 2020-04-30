using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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