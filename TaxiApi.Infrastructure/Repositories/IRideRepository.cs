using TaxiApi.Domain.Entities;

namespace TaxiApi.Infrastructure.Repositories
{
	public interface IRideRepository
	{
		public IEnumerable<Ride> Get();
		public int Create(Ride ride);
		public int Update(Ride ride);
		public int Delete(Ride ride);
	}
}
