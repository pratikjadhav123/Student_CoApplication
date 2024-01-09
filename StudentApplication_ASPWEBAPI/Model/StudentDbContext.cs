using Microsoft.EntityFrameworkCore;

namespace StudentApplication_ASPWEBAPI.Model
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-4N34TBLJ\\SQLEXPRESS;Initial Catalog=Student_Details;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
