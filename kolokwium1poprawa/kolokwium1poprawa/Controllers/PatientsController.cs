using kolokwium1poprawa.Models;
using kolokwium1poprawa.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Controllers
{
    [ApiController]
    [Route("/api/patients")]
    public class PatientsController : Controller
    {
        private readonly IMedService _service;

        public PatientsController(IMedService service)
        {
          
            _service = service;
        }

        [HttpDelete("{idPatient}")]
        public async Task<ActionResult<Patient>> DeletePatients(int idPatient)
        {
            try
            {
                var patientToDelete = _service.GetPatient(idPatient);

                if (patientToDelete == null)
                {
                    return NotFound($"Patient has not been founded");
                }

                return _service.DeletePatient(idPatient);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
