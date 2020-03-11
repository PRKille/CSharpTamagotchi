using System;
using System.Collections.Generic;

namespace Tomagotchi.Models
{
  public class Pet
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Play { get; set; }
    public int Sleep { get; set; }
    public int Days { get; set; }
    public int Id { get; }
    private static List<Pet> _pets = new List<Pet>(); 

    public Pet(string name)
    {
      Name = name;
      Food = 50;
      Play = 50;
      Sleep = 50;
      Days = 0;
      _pets.Add(this);
      Id = _pets.Count;
    }
    public static List<Pet> GetAll()
    {
      return _pets;
    }
    public void FeedPet()
    {
      Food += 4;
    }
    public void PlayPet()
    {
      Play += 4;
    }
    public void SleepPet()
    {
      Sleep += 4;
    }
    public static void PassTime()
    {
      foreach (Pet pet in _pets)
      {
        pet.Food -= 7;
        pet.Play -= 7;
        pet.Sleep -= 7;
        pet.Days++;
      }
    }

  }
}