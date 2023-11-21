using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Commands;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.Queries;

/*
 add mediator?
 
 */
namespace TaxiApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RideController : ControllerBase
	{
		private readonly ILogger<VehicleAvailabilityController> _logger;
		private readonly RideCommandHandler _commandHandler;
		private readonly GetRidesQueryHandler _queryHandler;

		public RideController(ILogger<VehicleAvailabilityController> logger,
			RideCommandHandler commandHandler,
			GetRidesQueryHandler queryHandler)
		{
			_logger = logger;
			_commandHandler = commandHandler;
			_queryHandler = queryHandler;
		}

		[HttpGet]
		public IActionResult GetAll()
		{
			return Ok(_queryHandler.Get());
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			return Ok(_queryHandler.Get(id));
		}
		[HttpPost("/propositions/")]
		public IActionResult GetPropositions(GetRidePropositionsQuery query)
		{
			return Ok(_queryHandler.Get());
		}

		[HttpPost]
		public IActionResult Post()
		{
			return Ok(_commandHandler.Create(null));
		}
	}
}