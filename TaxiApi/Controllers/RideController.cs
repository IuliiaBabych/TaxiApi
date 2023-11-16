using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Services;

namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RideController : ControllerBase
	{
		private readonly ILogger<VehicleController> _logger;
		private readonly IRideService _service;

		public RideController(ILogger<VehicleController> logger, IRideService service)
		{
			_logger = logger;
			_service = service;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_service.GetAll());
		}

		[HttpPost]
		public IActionResult Post()
		{

			return Ok(_service.Get(0));
		}
	}
}