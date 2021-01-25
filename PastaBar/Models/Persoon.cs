using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PastaBar.Models
{
    public class Persoon
    {

        


        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        [RegularExpression(@"^.+@.+\..+$", ErrorMessage = "ongeldig Email adres")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public long Telefoon { get; set; }


        [Required]
        [Verleden(ErrorMessage = "Geboortedatum moet in het verleden liggen")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]

        public DateTime Geboortedatum { get; set; }





    }
}
