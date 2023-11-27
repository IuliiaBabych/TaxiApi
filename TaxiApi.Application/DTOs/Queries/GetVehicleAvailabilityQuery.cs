using TaxiApi.Domain.Entities;

namespace TaxiApi.Application.DTOs.Queries
{
	public class GetVehicleAvailabilityQuery
	{
		public Address Pickup { get; set; }
		public DateTime PickupTime { get; set; }
	}
}
