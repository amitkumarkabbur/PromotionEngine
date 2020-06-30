namespace PromotionEngine 
{
  class Program
  {
     static void Main(string[] args)
     {
     
      #region "Scenario A"
            Order scenarioA = new Order(1, new List<Product>() { new Product("A", 1), new Product("B", 1), new Product("C", 1) });
            decimal finalPrice = PromotionBusinessRules.GetFinalPrice(scenarioA);
      #endregion
      
      
      
     }
     
     
  }
}
