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

		public IEnumerable<RideDTO> Get(GetRidePropositionsQuery query)
		{
			var list = _repository.Get();
			
			return _mapper.Map<IEnumerable<Ride>, IEnumerable<RideDTO>>(list);
		}
	}
}
