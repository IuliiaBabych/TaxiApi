using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.Queries;

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

		[HttpGet("{time}/{latitude}/{longitude}")]
		public IActionResult Get(DateTime time, double latitude, double longitude)
		{
			return Ok(_handler.Get(new GetVehicleAvailabilityQuery()
			{
				Pickup = new Domain.Entities.Address() { Latitude = latitude, Longitude = longitude},
				PickupTime = time
			}));
		}
	}
}