using AutoMapper;
using TaxiApi.Application.DTOs;
using TaxiApi.Infrastructure.Repositories;

namespace TaxiApi.Application.Commands
{
	public class RideCommandHandler
	{
		private readonly IRideRepository _repository;
		private readonly IMapper _mapper;
		public RideCommandHandler(IRideRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public int Create(RideDTO ride)
		{
			return 0;
		}
	}
}
