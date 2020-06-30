using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
   [TestClass]
    public class Tests
    {
      [TestMethod]
      public void NoPromotionTest()
      {
          Order order = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("B", 30.0) });
          Assert.AreEqual(80, PromotionBusinessRules.GetFinalPrice(order));
      }
      
      [TestMethod]
      public void ScenarioOneTest()
      {
          Order order = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0),
                                    new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0), new Product("C", 20.0)});
          Assert.AreEqual(370, PromotionBusinessRules.GetFinalPrice(order));
      }
      
      [TestMethod]
      public void ScenarioTwoTest()
      {
          Order order = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0), 
                                    new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0),
                                    new Product("C", 20.0), new Product("D", 30.0)});
          Assert.AreEqual(280, PromotionBusinessRules.GetFinalPrice(order));
      }
    }
}
