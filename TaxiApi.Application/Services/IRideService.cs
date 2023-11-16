using TaxiApi.Application.DTOs;

namespace TaxiApi.Application.Services
{
	public interface IRideService
	{
		IEnumerable<RideDTO> GetAll();
		IEnumerable<RideDTO> Get(int id);
		IEnumerable<RideDTO> Get(DateTime pickupTimeFrom, DateTime pickupTimeTo);
		IEnumerable<RideDTO> GetCustomerRides(int customerId);


		int Create(RideDTO ride);
	}
}