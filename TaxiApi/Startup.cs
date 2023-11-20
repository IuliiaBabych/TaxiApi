using TaxiApi.Application.Mappers;
using TaxiApi.Application.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TaxiApi.Application;

namespace TaxiApi
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen();
			services.AddAutoMapper(typeof(MappingProfile));
			ApplicationRegistrar.RegisterApplicationServices(services);
		}
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			// Configure middleware components (logging, authentication, etc.)
			app.UseSwagger();
			app.UseSwaggerUI();
			//app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
				// Add other endpoints...
			});
		}
	}
}
