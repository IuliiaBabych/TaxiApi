using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Application.DTOs.Queries
{
	public class GetRidePropositionsQuery
	{
		public Address PickupLocation { get; set; }
		public DateTime PickupTime { get; set; }

		public Address DropoffLocation { get; set; }
		public IList<VehicleType> VehicleTypes { get; set; }
	}
}
