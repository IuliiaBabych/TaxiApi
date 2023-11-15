using TaxiApi.Domain.Enums;

namespace TaxiApi.Application.DTOs
{
	public class VehicleDTO
	{
		public string Number { get; set; }
		public string AutoMakerName { get; set; }
		public string Model { get; set; }
		public VehicleType Type { get; set; }
	}
}