using TaxiApi.Domain.Entities;

namespace TaxiApi.Infrastructure.Repositories
{
	public class VehicleAvailabilityRepository : IVehicleAvailabilityRepository
	{
		public IEnumerable<VehicleAvailability> Get(DateTime time, Address pickup)
		{
			return null;
		}
	}
}
