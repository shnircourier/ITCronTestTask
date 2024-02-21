using AutoMapper;
using ITCronTestTask.Data.Entities;
using ITCronTestTask.Domain.Models;

namespace ITCronTestTask.Data;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<IpInfo, IpInfoHistory>().ReverseMap();
    }
}