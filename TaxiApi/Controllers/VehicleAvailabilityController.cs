using Microsoft.AspNetCore.Mvc;
using Microsoft.Spatial;
using System.Drawing;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.Queries;
using TaxiApi.Application.Services;

namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class VehicleAvailabilityController : ControllerBase
	{
		private readonly ILogger<VehicleAvailabilityController> _logger;
		private readonly GetVehicleAvailabilityQueryHandler _handler;

		public VehicleAvailabilityController(ILogger<VehicleAvailabilityController> logger, GetVehicleAvailabilityQueryHandler handler)
		{
			_logger = logger;
			_handler = handler;
		}

		[HttpGet("{time}/{x}/{y}")]
		public IActionResult Get(DateTime time, double x, double y)
		{
			return Ok(_handler.Get(new GetVehicleAvailabilityQuery()
			{
				Pickup = GeometryPoint.Create(x, y),
				PickupTime = time
			}));
		}
	}
}