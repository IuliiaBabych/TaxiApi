using TaxiApi.Domain.Entities;
using TaxiApi.Domain.Enums;

namespace TaxiApi.Infrastructure.Repositories
{
	public class RideRepository : IRideRepository
	{
		public IEnumerable<Ride> Get()
		{
			return new List<Ride>() {
				new Ride()
				{
					Id = 1,
					PickupTime = DateTime.UtcNow,
					Customer = new Customer()
					{
						Id = 1,
						FirstName = "Yuliia",
						LastName  = "Babych",
						PhoneNumber = "0958705909"
					},
					Vehicle = new Vehicle()
					{
						Id = 1,
						Number = "AK1234BC"
					},
					Driver = new Driver()
					{
						Id = 1,
						LicenseNumber = "AS234275782BN",
						FirstName = "Oleg"
					},
					PickupLocation = new Address()
					{
						City = "Kyiv",
						Street = "Peremogy",
						BuildingNumber = "55"
					},
					DropoffLocation = new Address()
					{
						City = "Kyiv",
						Street = "Holosiivska",
						BuildingNumber = "55"
					},
					Status = RideStatus.Completed,
					Price = 54
				}
			};
		}
		public Ride Get(int id)
		{
			return Get().FirstOrDefault(q => q.Id == id);
		}
		public int Create(Ride ride)
		{
			return 0;
		}
		public int Update(Ride ride)
		{
			return 0;
		}
		public int Delete(Ride ride)
		{
			return 0;
		}
	}
}
