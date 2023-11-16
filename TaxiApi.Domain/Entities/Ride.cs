using TaxiApi.Domain.Enums;

namespace TaxiApi.Domain.Entities
{
	public class Ride
	{
		public int Id { get; set; }
		public Address PickupLocation { get; set; }
		public DateTime PickupTime { get; set; }
		public Address DropoffLocation { get; set; }
		public IList<VehicleType> VehicleTypes { get; set; }
		public Customer Customer { get; set; }
	}
}
