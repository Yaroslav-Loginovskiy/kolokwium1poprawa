using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class Medicament
    {
        [Required]
        public int IdMedicament { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required] public string Type { get; set; }
        [Required] public string PrescriptionMedicament { get; set; }
    }
}
