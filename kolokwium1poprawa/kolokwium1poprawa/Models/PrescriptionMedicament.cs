using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class PrescriptionMedicament
    {
 
        public int IdPrescription { get; set; }

        public int IdMedicament { get; set; }

        public int Dose { get; set; }

        public string Details { get; set; }

        public Prescription Prescription { get; set; }
       

        public Medicament Medicament { get; set; }
    }
}
