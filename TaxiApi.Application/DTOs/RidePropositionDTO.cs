namespace TaxiApi.Application.DTOs
{
	public class RidePropositionDTO
	{
		public int Id { get; set; }
		public DriverDTO Driver { get; set; }
		public VehicleDTO Vehicle { get; set; }
		public float Price { get; set; }
	}
}
