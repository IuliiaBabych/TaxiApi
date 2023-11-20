using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Domain.Entities;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Queries
{
	public class GetRidesQueryHandler
	{
		private readonly IRideRepository _repository;
		private readonly IMapper _mapper;
		public GetRidesQueryHandler(IRideRepository repository, IMapper mapper) {
			_repository = repository;
			_mapper = mapper;
		}

		public IEnumerable<RideDTO> Get()
		{
			var list = _repository.Get();

			return _mapper.Map<IEnumerable<Ride>, IEnumerable<RideDTO>>(list);
		}

		public RideDTO Get(int id)
		{
			var query = _repository.Get(id);

			return _mapper.Map<Ride, RideDTO>(query);
		}
	}
}
