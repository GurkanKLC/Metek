using AutoMapper;
using Metek.Application.Features.Mesai.Commands.Update;
using Metek.Domain.Entities;
using System;
using D = Metek.Domain.Entities;

namespace Metek.Application.Resolver
{
    public class UpdateMesaiCommandToMesaiResolver : ITypeConverter<UpdateMesaiCommand, D.Mesai>
    {

        public Mesai Convert(UpdateMesaiCommand source, Mesai destination, ResolutionContext context)
        {
            D.Mesai mesai = new D.Mesai();
            mesai.Id = source.mesaiUpdateRequest.Id;
            mesai.Personel=source.mesaiUpdateRequest.Personel;
            mesai.ProcessTime = source.mesaiUpdateRequest.ProcessTime;
            mesai.ProcessStatus = source.mesaiUpdateRequest.ProcessStatus;
            mesai.CreatedDate = DateTime.UtcNow;
            mesai.UpdatedDate = DateTime.UtcNow;
            mesai.DeletedDate = null;


            return mesai;
        }
    }
}
