// Data/TarefasContext.cs
using Microsoft.EntityFrameworkCore;
public class TarefasContext : DbContext
{
    public TarefasContext(DbContextOptions<TarefasContext> options) : base(options) { }
    public DbSet<Tarefa> Tarefas { get; set; }
}
