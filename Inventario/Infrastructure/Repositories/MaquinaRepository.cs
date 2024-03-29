using Inventario.Application.DTOs;
using Inventario.Domain;
using Inventario.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Infrastructure.Repositories;

public class MaquinaRepository : IMaquinaRepository
{
    private readonly ContextDB _context;

    public MaquinaRepository(ContextDB context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TblMaquina>> GetAllAsync()
    {
        return await _context.TblMaquinas.ToListAsync();
    }

    public async Task<TblMaquina> GetByIdAsync(int id)
    {
        return await _context.TblMaquinas.FindAsync(id);
    }

    public async Task AddAsync(TblMaquina maquina)
    {
        _context.TblMaquinas.Add(maquina);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TblMaquina maquina)
    {
        _context.TblMaquinas.Entry(maquina).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(int id)
    {
        var maquina = await _context.TblMaquinas.FindAsync(id);
        _context.TblMaquinas.Remove(maquina);
        await _context.SaveChangesAsync();
    }
}
