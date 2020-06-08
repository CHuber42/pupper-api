using Microsoft.EntityFrameworkCore;

namespace Pupper.Models
{
    public class PupperContext : DbContext
    {
        public PupperContext(DbContextOptions<PupperContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Doggo>()
              .HasData(
                  new Doggo { DoggoId = 5, Name = "Matilda", Breed = "Mutt", Age = 7, Url = "https://t1.ea.ltmcdn.com/en/images/4/0/0/small_white_dog_breeds_3004_600.jpg", Gender = "Female" },
                  new Doggo { DoggoId = 6, Name = "Roxie", Breed = "Dinosaur", Age = 10, Gender = "Female" },
                  new Doggo { DoggoId = 7, Name = "Matilda", Breed = "Dinosaur", Age = 2, Gender = "Female" },
                  new Doggo { DoggoId = 24, Name = "Pip", Breed = "Sha5", Age = 24, Gender = "Male" },
                  new Doggo { DoggoId = 22, Name = "Bartholomew", Breed = "Dinosaur", Age = 22, Gender = "Male" }
              );
        }
        public DbSet<Doggo> Doggos { get; set; }
    }
}