using AutoMapper;
using Inventario.Application.DTOs;
using Inventario.Domain;
using Inventario.Domain.Interfaces;

namespace Inventario.Application.Services;

public class MaquinaService
{
    private readonly IMaquinaRepository _maquinaRepository;
    private readonly IMapper _mapper;

    public MaquinaService(IMaquinaRepository maquinaRepository, IMapper mapper)
    {
        _maquinaRepository = maquinaRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<MaquinaDto>> GetAllAsync()
    {
        var maquinas = await _maquinaRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<MaquinaDto>>(maquinas);
    }

    public async Task<MaquinaDto> GetByIdAsync(int id)
    {
        var maquina = await _maquinaRepository.GetByIdAsync(id);
        return _mapper.Map<MaquinaDto>(maquina);
    }

    public async Task<TblMaquina> AddAsync(CreateMaquinaDto createMaquinaDto)
    {
        var maquina = _mapper.Map<TblMaquina>(createMaquinaDto);
        await _maquinaRepository.AddAsync(maquina);
        return maquina;
    }

    public async Task UpdateAsync(int id, UpdateMaquinaDto updateMaquinaDto)
    {
        var maquina = await _maquinaRepository.GetByIdAsync(id);
        if (maquina is null) throw new Exception("Maquina not found");
        _mapper.Map(updateMaquinaDto, maquina);
        await _maquinaRepository.UpdateAsync(maquina);
    }

    public async Task RemoveAsync(int id)
    {
        await _maquinaRepository.RemoveAsync(id);
    }
}
