using System.Drawing;

namespace TaxiApi.Domain.Entities
{
	public class VehicleAvailability
	{
		public int Id { get; set; }
		public Vehicle Vehicle { get; set; }
		public Driver Driver { get; set; }

		public Point GpsPosition { get; set; }
		public DateTime Updated { get; set; }
		public bool IsActive { get; set; }

	}
}
