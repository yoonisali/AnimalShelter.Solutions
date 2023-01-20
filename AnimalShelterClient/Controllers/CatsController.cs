using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers;

public class CatsController : Controller
{
  public IActionResult Index()
  {
    List<Cat> cats = Cat.GetCats();
    return View(cats);
  }
}