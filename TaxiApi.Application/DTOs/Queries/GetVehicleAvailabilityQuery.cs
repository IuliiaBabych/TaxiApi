using Microsoft.Spatial;

namespace TaxiApi.Application.DTOs.Queries
{
	public class GetVehicleAvailabilityQuery
	{
		public GeometryPoint Pickup { get; set; }
		public DateTime PickupTime { get; set; }
	}
}
