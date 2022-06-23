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
        public IActionResult DeletePatients(int idPatient)
        {
            if (idPatient == 0)
            {
                return BadRequest();
            }
            _service.DeletePatient(idPatient);
            return Ok("Patient has been deleted");
        }
    }
}
