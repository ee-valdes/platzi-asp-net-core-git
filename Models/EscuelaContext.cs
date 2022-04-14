using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core_git.Models
{
    public class EscuelaContext: DbContext    
    {
        public DbSet<Escuela> Escuelas { get; set;}

        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}