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

  public IActionResult Details(int id)
  {
    Dog dog = Dog.GetDogDetails(id);
    return View(dog);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Dog dog)
  {
    Dog.PostDogs(dog);
    Thread.Sleep(600);
    return RedirectToAction("Index");
  }
}