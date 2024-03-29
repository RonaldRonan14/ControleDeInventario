using AutoMapper;
using Inventario.Application.DTOs;
using Inventario.Domain;

namespace Inventario.Application.Profiles;

public class MaquinaProfile : Profile
{
    public MaquinaProfile()
    {
        CreateMap<TblMaquina, MaquinaDto>();
        CreateMap<CreateMaquinaDto, TblMaquina>();
        CreateMap<UpdateMaquinaDto, TblMaquina>();
    }
}
