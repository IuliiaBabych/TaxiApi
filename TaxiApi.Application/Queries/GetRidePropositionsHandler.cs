using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Application.DTOs.Queries;
using TaxiApi.Domain.Entities;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Queries
{
	public class GetRidePropositionsHandler
	{
		private readonly IRideRepository _repository;
		private readonly IMapper _mapper;
		public GetRidePropositionsHandler(IRideRepository repository, IMapper mapper) {
			_repository = repository;
			_mapper = mapper;
		}

		public IEnumerable<RideDTO> Get(GetRidePropositionsQuery query)
		{
			
			//get available cars from repo
			//get car prices from repo
			//merge
			//return
			return null;
		}
		
	}
}
