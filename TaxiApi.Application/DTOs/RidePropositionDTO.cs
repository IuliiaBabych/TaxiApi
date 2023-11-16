namespace TaxiApi.Application.DTOs
{
	public class RidePropositionDTO
	{
		public int Id { get; set; }
		public int DriverId { get; set; }
		public int VehicleId { get; set; }
		public float Price { get; set; }
		public RideDTO Ride { get; set; }
	}
}
