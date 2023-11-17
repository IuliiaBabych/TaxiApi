using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Commands;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.Queries;

namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RideController : ControllerBase
	{
		private readonly ILogger<VehicleController> _logger;
		private readonly RideCommandHandler _commandHandler;
		private readonly GetRidesQueryHandler _queryHandler;

		public RideController(ILogger<VehicleController> logger,
			RideCommandHandler commandHandler,
			GetRidesQueryHandler queryHandler)
		{
			_logger = logger;
			_commandHandler = commandHandler;
			_queryHandler = queryHandler;
		}

		[HttpGet]
		public IActionResult Get(DateTime pickupTime)
		{
			return Ok(_queryHandler.Get(
				new GetRidePropositionsQuery() { PickupTime = DateTime.UtcNow }));
		}

		[HttpPost]
		public IActionResult Post()
		{
			return Ok(_commandHandler.Create(null));
		}
	}
}