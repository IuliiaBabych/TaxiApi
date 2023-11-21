using TaxiApi.Domain.Enums;

namespace TaxiApi.Domain.Entities
{
	public class Vehicle
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public string AutoMakerName { get; set; }
		public string Model { get; set; }
		public VehicleType Type { get; set; }
		public bool IsActive { get; set; }

	}
}