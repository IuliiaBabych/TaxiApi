using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Application.DTOs.Queries
{
	public class GetRidePropositionsQuery
	{
		public Address Pickup { get; set; }
		public DateTime PickupTime { get; set; }
		public Address Dropoff { get; set; }
		public IList<VehicleType> VehicleTypes { get; set; }
	}
}
