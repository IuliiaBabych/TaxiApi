using Microsoft.Spatial;
using System.Drawing;
using TaxiApi.Domain.Entities;

namespace TaxiApi.Infrastructure.Repositories
{
	public interface IVehicleAvailabilityRepository
	{
		public IEnumerable<VehicleAvailability> Get(DateTime time, GeometryPoint pickup);
	}
}
