using Data.EntityConfigurations;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        #region DbSets
        public virtual DbSet<User>? Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Rut = 155678905,
                Name = "Juan",
                LastName = "Soto",
                Email = "jsoto@gmail.com",
                Password = "123",
                BirthDate = new DateTime(1984,6,22)
                
               
            },
            new User
            {
                Id = 2,
                Rut = 145678905,
                Name = "Mariana",
                LastName = "Ramirez",
                Email = "mramirez@gmail.com",
                Password = "123",
                BirthDate = new DateTime(1994, 1, 31)
            }
        );;
        }
    }
}
