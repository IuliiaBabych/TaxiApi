using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Application.DTOs
{
	public class RideDTO
	{
		public int Id { get; set; }
		public Address PickupLocation { get; set; }
		public DateTime PickupTime { get; set; }

		public Address DropoffLocation { get; set; }
		public IList<VehicleType> VehicleTypes { get; set; }
		public CustomerDTO Customer { get; set; }
	}
}
