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
	public class RidePropositionController : ControllerBase
	{
		private readonly ILogger<VehicleAvailabilityController> _logger;
		private readonly GetRidePropositionsHandler _queryHandler;

		public RidePropositionController(ILogger<VehicleAvailabilityController> logger,
			GetRidePropositionsHandler queryHandler)
		{
			_logger = logger;
			_queryHandler = queryHandler;
		}

		[HttpPost("ride/propositions/")]
		public IActionResult GetPropositions(GetRidePropositionsQuery query)
		{
			return Ok(_queryHandler.Get(query));
		}
		  
	}
}