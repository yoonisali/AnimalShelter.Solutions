using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Cat 
  {
    public int CatId { get; set; }

    [Required]
    public string Name { get; set; }
  
    [Required]
    public string Breed { get; set; }
    
    [Required]
    [Range(0, 20, ErrorMessage = "Age must be between 1 and 20.")]
    public int Age { get; set; }
  }
}