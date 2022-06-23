using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class Prescription
    {
        [Required] 
        public int IdPrescription { get; set; }
        [Required] 
        public DateTime Date {get; set;}

        [Required]
        public string DueDate {get; set;}
    }
}
