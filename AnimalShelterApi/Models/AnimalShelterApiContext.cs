using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Dog> Dogs { get; set; }

    public DbSet<Cat> Cats { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Dog>()
        .HasData(
          new Dog { DogId = 1, Name = "Dogzilla", Breed = "Central Asian Shepherd Dog", Age = 6 },
          new Dog { DogId = 2, Name = "King George III", Breed = "Poodle", Age = 10 }
        );
        builder.Entity<Cat>()
        .HasData(
          new Cat { CatId = 1, Name = "Kit-Kat", Breed = "Savannah", Age = 4, },
          new Cat { CatId = 2, Name = "Simba", Breed = "Singapura", Age = 10, }
        );
    }
  }
}