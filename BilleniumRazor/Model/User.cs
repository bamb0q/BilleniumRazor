using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilleniumRazor.Model
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Wprowadź Imię")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Wprowadź Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Napisz Komentarz")]
        public string About { get; set; }
    }
}
