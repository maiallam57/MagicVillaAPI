using MagicVilla_villaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_villaAPI.Controllers
{
    [Route("/api/villaApi")]
    [ApiController]
    public class villaApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<villa> GetVillas()
        {
            return new List<villa>()
            {
                new villa{Id=1, Name ="pool villa"},
                new villa{Id=2, Name ="beach villa"}

            };
        }
    }
}
