using Microsoft.EntityFrameworkCore;

namespace roundthecode.pdf.Models
{
    public class StudentsDbContext: DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options): base (options)
        {
            
        }
        public DbSet<Student>? Students { get; set; }   
    }
}
