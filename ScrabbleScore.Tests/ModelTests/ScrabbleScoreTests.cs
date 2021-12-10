using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
    [TestClass]
    public class ScrabbleLogicTests
    {
      [TestMethod]
      public void TotalScore_AddOnePoint_1()
      {
        Assert.AreEqual(1, ScrabbleLogic.CalcScore("a"));
      }
      [TestMethod]
      public void TotalScore_AddPoints_8()
      {
        Assert.AreEqual(8, ScrabbleLogic.CalcScore("hello"));
      }
      [TestMethod]
      public void TotalScore_AddNewPoints_8()
      {
        Assert.AreEqual(8, ScrabbleLogic.CalcScore("HeLlO"));
      }
    }
}