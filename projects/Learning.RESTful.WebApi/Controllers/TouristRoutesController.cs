using Learning.RESTful.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learning.RESTful.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }
        [HttpGet]
        public IActionResult GetTouristRoutes()
        {
            var routes=_touristRouteRepository.GetTouristRoutes();
            return Ok(routes);
        }
    }
}
