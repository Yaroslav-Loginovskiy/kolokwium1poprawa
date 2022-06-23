using kolokwium1poprawa.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium1poprawa.Controllers
{
    [ApiController]
    [Route("/api/medicaments")]
    public class MedicamentController : Controller
    {
        private readonly IMedService _service;
        public MedicamentController(IMedService service)
        {
            _service = service;
        }

        [HttpGet("{idMedicament}")]
        public async Task<IActionResult> GetMedicament(int idMedicament)
        {
         
            try
            {
                var medicament = _service.GetMedicament(idMedicament);

                if (medicament == null) return NotFound();

                return await Task.FromResult<IActionResult>(Ok(_service.GetMedicament(idMedicament)));
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
