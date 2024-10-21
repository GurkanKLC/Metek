using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using D=Metek.Domain.Entities;
using AutoMapper;
using Metek.Application.Services;

namespace Metek.Application.Features.Mesai.Queries.GetList
{
    public class GetMesaiListQuery : IRequest<List<D.Mesai>>
    {

        public class GetMesaiListQueryHandler : IRequestHandler<GetMesaiListQuery, List<D.Mesai>>
        {
            private readonly ShiftCalculatorService _shiftCalculatorService;
            private IMapper _mapper;

            public GetMesaiListQueryHandler(ShiftCalculatorService shiftCalculatorService, IMapper mapper)
            {
                _shiftCalculatorService = shiftCalculatorService;
                _mapper = mapper;
            }
            public async Task<List<D.Mesai>> Handle(GetMesaiListQuery request, CancellationToken cancellationToken)
            {

                return await _shiftCalculatorService.GetListAsync();
            }
        }
    }
}
