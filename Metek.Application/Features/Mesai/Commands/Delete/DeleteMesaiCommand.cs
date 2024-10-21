using AutoMapper;
using MediatR;
using Metek.Application.Dtos.Mesai.Request;
using Metek.Application.Dtos.Mesai.Response;
using Metek.Application.Services;
using System;
using System.Threading;
using System.Threading.Tasks;
using D = Metek.Domain.Entities;


namespace Metek.Application.Features.Mesai.Commands.Delete
{
  

    public class DeleteMesaiCommand : IRequest<DeleteMesaiResponse>
    {
        public MesaiDeleteRequest mesaiDeleteRequest { get; set; }

        public class DeleteMesaiCommandHandler : IRequestHandler<DeleteMesaiCommand, DeleteMesaiResponse>
        {
            private readonly ShiftCalculatorService _shiftCalculatorService;
            private IMapper _mapper;

            public DeleteMesaiCommandHandler(ShiftCalculatorService shiftCalculatorService, IMapper mapper)
            {
                _shiftCalculatorService = shiftCalculatorService;
                _mapper = mapper;
            }


            public async Task<DeleteMesaiResponse> Handle(DeleteMesaiCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    D.Mesai mesai = _mapper.Map<D.Mesai>(request);
                    await _shiftCalculatorService.DeleteAsync(mesai);


                    return new DeleteMesaiResponse() { Result = "Başarılı" };
                }
                catch
                (Exception ex)
                {
                    return new DeleteMesaiResponse() { Result = "Başarısız" };


                }
            }
        }
    }
}
