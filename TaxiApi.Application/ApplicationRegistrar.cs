﻿using Microsoft.Extensions.DependencyInjection;
using TaxiApi.Application.Services;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application
{
	public static class ApplicationRegistrar
	{
		public static void RegisterApplicationServices(IServiceCollection services)
		{
			services.AddScoped<IVehicleService, VehicleService>();

			services.AddScoped<IVehicleRepository, VehicleRepository>();
		}
	}
}
