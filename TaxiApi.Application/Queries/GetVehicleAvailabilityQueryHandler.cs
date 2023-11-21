using AutoMapper;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Application.DTOs;
using TaxiApi.Infrastructure.Repositories;
using TaxiApi.Domain.Entities;

namespace TaxiApi.Application.Queries
{
	public class GetVehicleAvailabilityQueryHandler
	{
		private readonly IVehicleAvailabilityRepository _repository;
		private readonly IMapper _mapper;
		public GetVehicleAvailabilityQueryHandler(IVehicleAvailabilityRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public IEnumerable<VehicleAvailabilityDTO> Get(GetVehicleAvailabilityQuery query)
		{
			var list = _repository.Get(query.PickupTime, query.Pickup);
			return _mapper.Map<IEnumerable<VehicleAvailability>, IEnumerable<VehicleAvailabilityDTO>>(list);
		}
	}
}
