using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class PrescriptionMedicament
    {
        [Required] 
        public int IdPrescription { get; set; }
        [Required]
        public int IdMedicament { get; set; }
        [Required] 
        public int Dose { get; set; }
        [Required] 
        public string Details { get; set; }
        [Required]
        public Prescription Prescription { get; set; }
       
        [Required] 
        public Medicament Medicament { get; set; }
    }
}
