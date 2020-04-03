using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Todo_id.Models
{
    public class DB : DbContext
    {
        
        public DbSet<Tarefa> Tarefas {get; set;}

        // Conexão com o banco de dados SQL server:
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost;Database=ToDo;User ID=SA;Password=SqlTodo@;Integrated security=true;");
    }
}