using AutoMapper;
using Metek.Application.Features.Mesai.Commands.Delete;
using Metek.Domain.Entities;
using System;
using D = Metek.Domain.Entities;

namespace Metek.Application.Resolver
{
    public class DeleteMesaiCommandToMesaiResolver : ITypeConverter<DeleteMesaiCommand, D.Mesai>
    {

        public Mesai Convert(DeleteMesaiCommand source, Mesai destination, ResolutionContext context)
        {
            D.Mesai mesai = new D.Mesai();
            mesai.Id = source.mesaiDeleteRequest.Id;
            mesai.Personel=source.mesaiDeleteRequest.Personel;
            mesai.ProcessTime = source.mesaiDeleteRequest.ProcessTime;
            mesai.ProcessStatus = source.mesaiDeleteRequest.ProcessStatus;
            mesai.CreatedDate = DateTime.UtcNow;
            mesai.UpdatedDate = DateTime.UtcNow;
            mesai.DeletedDate = null;


            return mesai;
        }
    } 
}
