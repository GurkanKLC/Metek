using AutoMapper;
using MediatR;
using Metek.Application.Dtos.Mesai.Request;
using Metek.Application.Dtos.Mesai.Response;
using Metek.Application.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using D = Metek.Domain.Entities;

namespace Metek.Application.Features.Mesai.Commands.Update
{

    public class UpdateMesaiCommand : IRequest<UpdateMesaiResponse>
    {
        public MesaiUpdateRequest mesaiUpdateRequest { get; set; }

        public class UpdateMesaiCommandHandler : IRequestHandler<UpdateMesaiCommand, UpdateMesaiResponse>
        {
            private readonly ShiftCalculatorService _shiftCalculatorService;
            private IMapper _mapper;

            public UpdateMesaiCommandHandler(ShiftCalculatorService shiftCalculatorService, IMapper mapper)
            {
                _shiftCalculatorService = shiftCalculatorService;
                _mapper = mapper;
            }


            public async Task<UpdateMesaiResponse> Handle(UpdateMesaiCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    D.Mesai mesai = _mapper.Map<D.Mesai>(request);
                    await _shiftCalculatorService.UpdateAsync(mesai);


                    return new UpdateMesaiResponse() { Result = "Başarılı" };
                }
                catch
                (Exception ex)
                {
                    return new UpdateMesaiResponse() { Result = "Başarısız" };


                }
            }
        }
    }
}
