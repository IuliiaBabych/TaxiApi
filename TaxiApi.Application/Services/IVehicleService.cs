using TaxiApi.Application.DTOs;

namespace TaxiApi.Application.Services
{
	public interface IVehicleService
	{
		public IEnumerable<VehicleDTO> Get();
	}
}
