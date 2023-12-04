using Microsoft.AspNetCore.Mvc;
using TaxiApi.Application.Commands;
using TaxiApi.Application.DTOs;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.Queries;

/*
 add mediator?
 
 */
namespace TaxiApi.Controllers
{
	[ApiController]
	public class RidePropositionController : ControllerBase
	{
		private readonly ILogger<VehicleAvailabilityController> _logger;
		private readonly GetVehicleAvailabilityQueryHandler _vehicleAvailabilityQueryHandler;

		public RidePropositionController(ILogger<VehicleAvailabilityController> logger,
			GetVehicleAvailabilityQueryHandler vehicleAvailabilityQueryHandler)
		{
			_logger = logger;
			_vehicleAvailabilityQueryHandler = vehicleAvailabilityQueryHandler;
		}

		[HttpPost("Ride/Propositions/")]
		public IActionResult GetPropositions(GetRidePropositionsQuery query)
		{
			//get available cars 
			var vehicles = _vehicleAvailabilityQueryHandler.Get(
				new GetVehicleAvailabilityQuery()
				{
					PickupTime = query.PickupTime,
					Pickup = query.Pickup
				});
			//get car prices from repo

			//merge
			return Ok(new List<RidePropositionDTO> ());
		}
		  
	}
}