using Inventario.Application.DTOs;
using Inventario.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MaquinasController : ControllerBase
{
    private readonly MaquinaService _maquinaService;

    public MaquinasController(MaquinaService maquinaService)
    {
        _maquinaService = maquinaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MaquinaDto>>> GetAll()
    {
        var maquinas = await _maquinaService.GetAllAsync();
        return Ok(maquinas);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<MaquinaDto>> GetById(int id)
    {
        var maquina = await _maquinaService.GetByIdAsync(id);
        if (maquina is null) return NotFound();
        return Ok(maquina);
    }

    [HttpPost]
    public async Task<ActionResult<CreateMaquinaDto>> Add(CreateMaquinaDto createMaquinaDto)
    {
        var maquina = await _maquinaService.AddAsync(createMaquinaDto);
        return CreatedAtAction(nameof(GetById), new { id = maquina.Id }, maquina);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, UpdateMaquinaDto updateMaquinaDto)
    {
        await _maquinaService.UpdateAsync(id, updateMaquinaDto);
        return NoContent();
    }

    [HttpDelete("id:int")]
    public async Task<IActionResult> Remove(int id)
    {
        var maquina = await _maquinaService.GetByIdAsync(id);
        if (maquina is null) return NotFound();
        await _maquinaService.RemoveAsync(id);
        return NoContent();
    }
}
