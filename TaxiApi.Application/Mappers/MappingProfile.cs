using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Domain.Entities;

namespace TaxiApi.Application.Mappers
{
	public class MappingProfile : Profile
	{
		public MappingProfile() 
		{
			CreateMap<Vehicle, VehicleDTO>().ReverseMap();
			CreateMap<VehicleAvailability, VehicleAvailabilityDTO>().ReverseMap();

			CreateMap<Customer, CustomerDTO>().ReverseMap();
			CreateMap<Driver, DriverDTO>().ReverseMap();
			CreateMap<Ride, RideDTO>().ReverseMap();
			CreateMap<RideProposition, RidePropositionDTO>().ReverseMap();
		}
	}
}
