using AutoMapper;
using Metek.Application.Dtos.Mesai.Request;
using Metek.Application.Features.Mesai.Commands.Create;
using Metek.Application.Features.Mesai.Commands.Delete;
using Metek.Application.Features.Mesai.Commands.Update;
using Metek.Application.Resolver;
using Metek.Domain.Entities;

namespace Metek.Application.Profiles.MesaiProfiles
{

    public class MesaiProfile : Profile
    {
        public MesaiProfile()
        {

            CreateMap<MesaiAddRequest, Mesai>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()) 
                .ForMember(dest => dest.CreatedDate, opt => opt.Ignore()) 
                .ForMember(dest => dest.UpdatedDate, opt => opt.Ignore()).ReverseMap(); 

            CreateMap<CreateMesaiCommand, Mesai>()
            .ConvertUsing<CreateMesaiCommandToMesaiResolver>();  
            
            
            CreateMap<DeleteMesaiCommand, Mesai>()
            .ConvertUsing<DeleteMesaiCommandToMesaiResolver>();    

            CreateMap<UpdateMesaiCommand, Mesai>()
            .ConvertUsing<UpdateMesaiCommandToMesaiResolver>();
        }
    }
}
