using Microsoft.Spatial;
using System.Drawing;
using TaxiApi.Domain.Entities;

namespace TaxiApi.Application.DTOs
{
	public class VehicleAvailabilityDTO
	{
		public int Id { get; set; }
		public VehicleDTO Vehicle { get; set; }
		public DriverDTO Driver { get; set; }

		public GeometryPoint GpsPosition { get; set; }
		public DateTime Updated { get; set; }
	}
}
