using TaxiApi.Application.DTOs;

namespace TaxiApi.Application.Services
{
	public class VehicleService: IVehicleService
	{
		public IEnumerable<VehicleDTO> Get()
		{
			return new List<VehicleDTO>();
		}
	}
}
