using TaxiApi.Domain.Entities;

namespace TaxiApi.Infrastructure.Repositories
{
	public interface IVehicleRepository
	{
		public IEnumerable<Vehicle> Get();
	}
}
