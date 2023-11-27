namespace TaxiApi.Domain.Entities
{
	public class Address
	{
		public string City { get; set; }
		public string Street { get; set; }
		public string BuildingNumber { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}
