namespace TaxiApi.Domain.Entities
{
	public class RideProposition
	{
		public int Id { get; set; }
		public int DriverId { get; set; }
		public int VehicleId { get; set; }
		public float Price { get; set; }
		public Ride Ride { get; set; }
	}
}
