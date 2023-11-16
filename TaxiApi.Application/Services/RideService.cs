using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Domain.Entities;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Services
{
	public class RideService : IRideService
	{
		private readonly IRideRepository _repository;
		private readonly IMapper _mapper;
		public RideService(IRideRepository repository, IMapper mapper) {
			_repository = repository;
			_mapper = mapper;
		}
		public IEnumerable<RideDTO> GetAll()
		{
			var list = _repository.Get();
			
			return _mapper.Map<IEnumerable<Ride>, IEnumerable<RideDTO>>(list);
		}

		public IEnumerable<RideDTO> Get(int id)
		{
			return null;
		}
		public IEnumerable<RideDTO> Get(DateTime pickupTimeFrom, DateTime pickupTimeTo)

		{
			return null;
		}
		public IEnumerable<RideDTO> GetCustomerRides(int customerId)
		{
			return null;
		}
		public	int Create(RideDTO ride)
		{
			return 0;
		}
	}
}
