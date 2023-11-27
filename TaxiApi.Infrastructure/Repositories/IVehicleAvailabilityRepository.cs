using TaxiApi.Domain.Entities;

namespace TaxiApi.Infrastructure.Repositories
{
	public interface IVehicleAvailabilityRepository
	{
		public IEnumerable<VehicleAvailability> Get(DateTime time, Address pickup);
	}
}
