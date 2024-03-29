using Inventario.Domain;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Infrastructure;

public class ContextDB : DbContext
{
    public ContextDB(DbContextOptions<ContextDB> options) : base(options) { }
    public DbSet<TblMaquina> TblMaquinas { get; set; }
}
