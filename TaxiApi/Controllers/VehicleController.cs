using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Services;

namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VehicleController : ControllerBase
	{
		private readonly ILogger<VehicleController> _logger;
		private readonly IVehicleService _service;

		public VehicleController(ILogger<VehicleController> logger, IVehicleService service)
		{
			_logger = logger;
			_service = service;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_service.Get());
		}
	}
}