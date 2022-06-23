using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Models
{
    public class Prescription
    {
   
        public int IdPrescription { get; set; }
 
        public DateTime Date {get; set;}


        public string DueDate {get; set;}
    }
}
