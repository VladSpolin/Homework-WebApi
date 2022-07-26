using Microsoft.EntityFrameworkCore;
using HomeworkWebApi.Models.DbModels;
using HomeworkWebApi.Models.Seeds;

namespace HomeworkWebApi.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u=>u.ItsProfile).WithOne(p=>p.ItsUser).HasForeignKey<Profile>(p=>p.UserId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Seed(); //class ModelBuilderExtensions
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
