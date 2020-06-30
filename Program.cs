namespace PromotionEngine 
{
  class Program
  {
     static void Main(string[] args)
     {
     
      #region "Scenario A"
            Order scenarioA = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("B", 30.0), new Product("C", 20.0) });
            decimal finalPrice = PromotionBusinessRules.GetFinalPrice(scenarioA);
      #endregion
      
        #region "Scenario B"
        Order scenarioB = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0),
                                                          new Product("A", 50.0), new Product("A", 50.0), new Product("B", 30.0),
                                                          new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0),
                                                          new Product("B", 30.0), new Product("C", 20.0)
                                                          });
        decimal finalPrice2 = PromotionBusinessRules.GetFinalPrice(scenarioB);
        #endregion
      
        #region "Scenario C"
        Order scenarioC = new Order(1, new List<Product>() { new Product("A", 50.0), new Product("A", 50.0), new Product("A", 50.0),
                                                          new Product("B", 30.0), new Product("B", 30.0), new Product("B", 30.0),
                                                          new Product("B", 30.0), new Product("B", 30.0), new Product("C", 20.0),
                                                          new Product("D", 15.0)
                                                          });
        decimal finalPrice3 = PromotionBusinessRules.GetFinalPrice(scenarioC);
        #endregion
      
     }
     
     
  }
}
