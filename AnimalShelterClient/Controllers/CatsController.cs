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

  public IActionResult Details(int id)
  {
    Cat cat = Cat.GetCatDetails(id);
    return View(cat);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Cat cat)
  {
    Cat.PostCats(cat);
    Thread.Sleep(600);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Cat cat = Cat.GetCatDetails(id);
    return View(cat);
  }

  [HttpPost]
  public ActionResult Edit(Cat cat)
  {
    Cat.PutCats(cat);
    Thread.Sleep(600);
    return RedirectToAction("Details", new { id = cat.CatId});
  }

  public ActionResult Delete(int id)
  {
    Cat cat = Cat.GetCatDetails(id);
    return View(cat);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Cat.DeleteCats(id);
    Thread.Sleep(600);
    return RedirectToAction("Index");
  }


}