using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Services;

namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VehiclesController : ControllerBase
	{
		

		private readonly ILogger<VehiclesController> _logger;
		private readonly IVehicleService _service;

		public VehiclesController(ILogger<VehiclesController> logger, IVehicleService service)
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