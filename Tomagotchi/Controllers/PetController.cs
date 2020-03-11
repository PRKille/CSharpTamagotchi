using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tomagotchi.Models;

namespace Tomagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> petList = Pet.GetAll();
      return View(petList);
    }
    [HttpPost("/index/{id}")]
    public ActionResult Update(int id, string food, string play, string sleep, string days)
    {
      Pet interactPet = Pet.GetAll()[id-1];
      if (food == "true")
      {
        interactPet.FeedPet();
        return RedirectToAction("Index");
      }
      else if (play == "true")
      {
        interactPet.PlayPet();
        return RedirectToAction("Index");
      }
      else if (sleep == "true")
      {
        interactPet.SleepPet();
        return RedirectToAction("Index");
      }
      else
      {
        return RedirectToAction("Index");
      }
      }

      [HttpPost("/index")]
      public ActionResult Update(string days)
      {
      if (days == "true")
        {
          Pet.PassTime();
          return RedirectToAction("Index");
        }
      else
      {
        return RedirectToAction("Index");
      }
    }
  }
}