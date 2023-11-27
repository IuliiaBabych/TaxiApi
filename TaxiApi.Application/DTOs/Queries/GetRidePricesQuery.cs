using Microsoft.Spatial;
using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Application.DTOs.Queries
{
	public class GetRidePricesQuery
	{
		public GeometryPoint Pickup { get; set; }
		public DateTime PickupTime { get; set; }
		public GeometryPoint Dropoff { get; set; }
		public IList<VehicleType> VehicleTypes { get; set; }
	}
}
