using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Infrastructure.Repositories
{
	public class VehicleRepository : IVehicleRepository
	{
		public IEnumerable<Vehicle> Get()
		{
			return new List<Vehicle>()
			{
				new Vehicle {
					Type = VehicleType.Sedan,
					AutoMakerName = "BMW",
					Model = "S1",
					Number = "12345"
				}
			};
		}
	}
}
