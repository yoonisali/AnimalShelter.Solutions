using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers;

public class DogsController : Controller
{
  public IActionResult Index()
  {
    List<Dog> dogs = Dog.GetDogs();
    return View(dogs);
  }
}