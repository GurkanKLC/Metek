using AutoMapper;
using MediatR;
using Metek.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Metek.Application.Dtos.Mesai.Response;

namespace Metek.Application.Features.Mesai.Queries.GetShift
{
  

    public class GetShiftListQuery : IRequest<List<ShiftResponse>>
    {

        public class GetShiftListQueryHandler : IRequestHandler<GetShiftListQuery, List<ShiftResponse>>
        {
            private readonly ShiftCalculatorService _shiftCalculatorService;
            private IMapper _mapper;

            public GetShiftListQueryHandler(ShiftCalculatorService shiftCalculatorService, IMapper mapper)
            {
                _shiftCalculatorService = shiftCalculatorService;
                _mapper = mapper;
            }
            public async Task<List<ShiftResponse>> Handle(GetShiftListQuery request, CancellationToken cancellationToken)
            {

                return await _shiftCalculatorService.CalculateWorkHoursAsync();
            }
        }
    }
}
