using jwtWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jwtWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScholarController : ControllerBase
    {
        private static readonly string[] Names = new[]
{
        "Juan Carlos", "Jose Carlos", "Mateo Luis", "Marcos Luis", "Jacob Marcelo"
        };

        private static readonly string[] LastNames = new[]{
        "Mendoza Cadena", "Miranda Lopez", "Calle Perez", "Martos Mejia", "Aguilar Chavez"
        };

        private static readonly string[] Universities = new[]{
        "UMSA", "UMSS", "UCB", "UTB", "EMI"
        };

        private static readonly string[] InstitutionalEmails = new[]{
        "Juan@funacionJala.com", "Jose@funacionJala.com", "Mateo@funacionJala.com", "Marcos@funacionJala.com", "Jacob@funacionJala.com"
        };

        [HttpGet, Authorize]
        public IEnumerable<Scholar> GetScholars()
        {
            return Enumerable.Range(1, 5).Select(index => new Scholar
            {
                Id = index,
                Name = Names[index - 1],
                LastName = LastNames[index - 1],
                University = Universities[index - 1],
                InstitutionalEmail = InstitutionalEmails[index - 1]
            })
          .ToArray();
        }
    }
}
