using Microsoft.AspNetCore.Mvc;
using CREAS_API.Models;

namespace CREAS_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreatineController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult CalculateDose([FromBody] CreatineRequest request)
        {
            double dose = request.BodyMassKg * 0.1;

            return Ok(new
            {
                BodyMassKg = request.BodyMassKg,
                DoseGrams = dose
            });
        }
    }
}
