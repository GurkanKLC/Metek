using AutoMapper;
using Metek.Application.Dtos.Mesai.Request;
using Metek.Application.Features.Mesai.Commands.Create;
using Metek.Domain.Entities;
using System;
using D = Metek.Domain.Entities;

namespace Metek.Application.Resolver
{
    public class CreateMesaiCommandToMesaiResolver : ITypeConverter<CreateMesaiCommand, D.Mesai>
    {

        public Mesai Convert(CreateMesaiCommand source, Mesai destination, ResolutionContext context)
        {
            D.Mesai mesai = new D.Mesai();
            mesai.Personel=source.mesaiAddRequest.Personel;
            mesai.ProcessTime = source.mesaiAddRequest.ProcessTime;
            mesai.ProcessStatus = source.mesaiAddRequest.ProcessStatus;
            mesai.CreatedDate = DateTime.UtcNow;
            mesai.UpdatedDate = DateTime.UtcNow;
            mesai.DeletedDate = null;


            return mesai;
        }
    }
}
