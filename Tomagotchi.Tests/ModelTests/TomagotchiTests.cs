using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tomagotchi.Models;
using System.Collections.Generic;
using System;

namespace Tomagotchi.Test
{
  [TestClass]
  public class TomagotchiTests
  {   
    [TestMethod]
    public void FeedPet_IsFeedingTomagatchi_54()
    {
      Pet testTomagatchi = new Pet ("TestMagotchi");
      testTomagatchi.FeedPet();
      Assert.AreEqual(testTomagatchi.Food, 54);
    }
    
    [TestMethod]
    public void PlayPet_IsPlayingTomagatchi_54()
    {
      Pet testTomagatchi = new Pet ("TestMagotchi");
      testTomagatchi.PlayPet();
      Assert.AreEqual(testTomagatchi.Play, 54);
    }
    
    [TestMethod]
    public void Sleep_IsSleepingTomagatchi_54()
    {
      Pet testTomagatchi = new Pet ("TestMagotchi");
      testTomagatchi.SleepPet();
      Assert.AreEqual(testTomagatchi.Sleep, 54);
    }
    
    [TestMethod]
    public void PassTime_IsDecrementingTomagatchi_43()
    {
      Pet testTomagatchi = new Pet ("TestMagotchi");
      Pet testTomagatchi1 = new Pet ("TestMagotchi");
      Pet testTomagatchi2 = new Pet ("TestMagotchi");
      Pet.PassTime();
      Assert.AreEqual(43, testTomagatchi.Sleep);
      Assert.AreEqual(43, testTomagatchi1.Food);
      Assert.AreEqual(43, testTomagatchi2.Play);
    }
  }
}