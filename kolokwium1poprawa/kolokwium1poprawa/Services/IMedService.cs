using kolokwium1poprawa.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Services
{
   public interface IMedService
    {
        public IEnumerable<Medicament> GetMedicament(int IdMedicament);
        void DeletePatient(int idPatient);
        public IEnumerable<Patient> GetPatient(int IdPatient);

    }
}
