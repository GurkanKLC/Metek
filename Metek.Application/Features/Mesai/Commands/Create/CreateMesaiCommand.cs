using AutoMapper;
using MediatR;
using Metek.Application.Dtos.Mesai.Request;
using Metek.Application.Dtos.Mesai.Response;
using Metek.Application.Services;
using System;
using D=Metek.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Metek.Application.Features.Mesai.Commands.Create
{

    public class CreateMesaiCommand : IRequest<CreateMesaiResponse>
    {
        public MesaiAddRequest mesaiAddRequest { get; set; }

        public class CreateMesaiCommandHandler : IRequestHandler<CreateMesaiCommand, CreateMesaiResponse>
        {
            private readonly ShiftCalculatorService _shiftCalculatorService;
            private IMapper _mapper;

            public CreateMesaiCommandHandler(ShiftCalculatorService shiftCalculatorService,IMapper mapper)
            {
                _shiftCalculatorService = shiftCalculatorService;
                _mapper = mapper;
            }

         
            public async Task<CreateMesaiResponse> Handle(CreateMesaiCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    D.Mesai mesai = _mapper.Map<D.Mesai>(request);
                    await _shiftCalculatorService.AddAsync(mesai);
                   

                    return new CreateMesaiResponse() { Result = "Başarılı" };
                }
                catch
                (Exception ex)
                {
                    return new CreateMesaiResponse() { Result = "Başarısız" };


                }
            }
        }
    }
}
