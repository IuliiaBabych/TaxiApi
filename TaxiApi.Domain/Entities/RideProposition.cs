namespace TaxiApi.Domain.Entities
{
	public class RideProposition
	{
		public int Id { get; set; }
		public Driver Driver { get; set; }
		public Vehicle Vehicle { get; set; }
		public float Price { get; set; }
	}
}
