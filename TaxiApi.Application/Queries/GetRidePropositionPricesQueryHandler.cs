using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Queries
{
	public class GetRidePropositionPricesQueryHandler
	{
		private readonly IRideRepository _repository;
		private readonly IMapper _mapper;
		public GetRidePropositionPricesQueryHandler(IRideRepository repository, IMapper mapper) {
			_repository = repository;
			_mapper = mapper;
		}

		public RidePropositionPriceDTO Get()
		{
			var list = _repository.Get();

			return new RidePropositionPriceDTO();
		}
	}
}
