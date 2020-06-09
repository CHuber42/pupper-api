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
                  new Doggo 
                  { 

                    DoggoId = 1, 
                    Name = "Matilda", 
                    Breed = "Mutt",
                    Age = 7, 
                    PicUrl = "https://t1.ea.ltmcdn.com/en/images/4/0/0/small_white_dog_breeds_3004_600.jpg",
                    Gender = "Female" 
                      
                  },

                   new Doggo 
                  { 

                    DoggoId = 2, 
                    Name = "Bagera", 
                    Breed = "Dachshund",
                     Age = 11, 
                     PicUrl = "https://i.pinimg.com/originals/0c/dc/6b/0cdc6b9ea47cdee8ff88c1d6c9e02ca7.jpg",
                      Gender = "Male" 

                  },
                   new Doggo 
                  {

                    DoggoId = 3, 
                    Name = "Flash", 
                    Breed = "Mutt",
                     Age = 2, 
                     PicUrl = "https://www.sciencesource.com/Doc/TR1_WATERMARKED/0/f/c/f/SS2695389.jpg?d63644087851",
                      Gender = "Male" 

                  }
          
              );
        }
        public DbSet<Doggo> Doggos { get; set; }
    }
}