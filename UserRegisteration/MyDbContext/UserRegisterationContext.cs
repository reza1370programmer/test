

using Microsoft.EntityFrameworkCore;

namespace UserRegisteration.MyDbContext
{
    public class UserRegisterationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HV8O6UV;Initial Catalog=UserRegisteration;TrustServerCertificate=True;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasKey(p => p.Id);
            modelBuilder.Entity<Student>().Property(p => p.FirstName).HasMaxLength(100).IsRequired(false);
            modelBuilder.Entity<Student>().Property(p => p.LastName).HasMaxLength(100);
            modelBuilder.Entity<Student>().Property(p => p.Mobile).HasMaxLength(80);
            modelBuilder.Entity<Student>().Property(p => p.Address).HasMaxLength(300);

            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, FirstName = "reza", LastName = "mohammdi", Mobile = "09142362545", Address = "tabriz" }
                );

        }
    }
}
