using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NBSoft.Application.Interfaces.IRepository;
using NBSoft.Domain.Model.MasterPanel;
using NBSoft.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Application.Features.CountryInfo.Queries.GetAllCountries
{
public record GetAllCountryQuery : IRequest<Result<List<GetAllCountryDto>>>;

    internal class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, Result<List<GetAllCountryDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllCountryQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllCountryDto>>> Handle(GetAllCountryQuery query, CancellationToken cancellationToken)
        {
            var Country = await _unitOfWork.Repository<Country>().Entities
                   .ProjectTo<GetAllCountryDto>(_mapper.ConfigurationProvider)
                   .ToListAsync(cancellationToken);

            return await Result<List<GetAllCountryDto>>.SuccessAsync(Country);
        }
    }
}
