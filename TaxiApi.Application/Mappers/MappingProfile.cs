using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Domain.Entities;

namespace TaxiApi.Application.Mappers
{
	public class MappingProfile : Profile
	{
		public MappingProfile() 
		{
			CreateMap<Vehicle, VehicleDTO>();
			CreateMap<VehicleDTO, Vehicle>();
		}
	}
}
