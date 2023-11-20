using TaxiApi.Domain.Enums;

namespace TaxiApi.Domain.Entities
{
	/*
	 add currency?
	 */
	public class Ride
	{
		public int Id { get; set; }
		public Address PickupLocation { get; set; }
		public DateTime PickupTime { get; set; }
		public Address DropoffLocation { get; set; }
		public Vehicle Vehicle { get; set; }
		public Driver Driver { get; set; }
		public Customer Customer { get; set; }
		public float Price { get; set; }
		public RideStatus Status { get; set; } 
	}
}
