using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Domain.Entities;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Services
{
	public class VehicleService: IVehicleService
	{
		private readonly IVehicleRepository _repository;
		private readonly IMapper _mapper;
		public VehicleService(IVehicleRepository repository, IMapper mapper) {
			_repository = repository;
			_mapper = mapper;
		}
		public IEnumerable<VehicleDTO> Get()
		{
			var list = _repository.Get();
			
			return _mapper.Map<IEnumerable<Vehicle>, IEnumerable<VehicleDTO>>(list);
		}
	}
}
