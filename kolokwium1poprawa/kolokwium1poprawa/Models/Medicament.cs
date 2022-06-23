using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class Medicament
    {

        public int IdMedicament { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

  
        public string Type { get; set; }
  
        public string PrescriptionMedicament { get; set; }
    }
}
