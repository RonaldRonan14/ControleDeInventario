using Inventario.Application.DTOs;

namespace Inventario.Domain.Interfaces;

public interface IMaquinaRepository
{
    Task<IEnumerable<TblMaquina>> GetAllAsync();
    Task<TblMaquina> GetByIdAsync(int id);
    Task AddAsync(TblMaquina maquina);
    Task UpdateAsync(TblMaquina maquina);
    Task RemoveAsync(int id);
}
