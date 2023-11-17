using Microsoft.Extensions.DependencyInjection;
using TaxiApi.Application.Commands;
using TaxiApi.Application.Queries;
using TaxiApi.Application.Services;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application
{
    public static class ApplicationRegistrar
	{
		public static void RegisterApplicationServices(IServiceCollection services)
		{

			services.AddScoped<GetRidesQueryHandler>();

			services.AddScoped<IVehicleService, VehicleService>();
			services.AddScoped<RideCommandHandler>();

			services.AddScoped<IVehicleRepository, VehicleRepository>();
			services.AddScoped<IRideRepository, RideRepository>();
		}
	}
}
