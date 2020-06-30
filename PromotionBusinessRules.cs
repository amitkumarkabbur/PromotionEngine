namespace PromotionEngine
{
public class PromotionBusinessRules
{

  public static decimal GetFinalPrice(Order order)
  {
      List<decimal> discountprices = PromotionBusinessRules.GetActivePromotions()
              .Select(promo => PromotionBusinessRules.GetDiscountPrice(order, promo))
              .ToList();
      decimal origprice = order.Products.Sum(x => x.UnitPrice);
      decimal discountPrice = discountprices.Sum();
      return origprice - discountPrice;
  }



  private static List<Promotion> GetActivePromotions()
  {
    Dictionary<Product, int> promotion1 = new Dictionary<Product, int>();
    promotion1.Add(new Product("A"), 3);
    Dictionary<Product, int> promotion2= new Dictionary<Product, int>();
    promotion2.Add(new Product("B"), 2);
    Dictionary<Product, int> promotion3 = new Dictionary<Product, int>();
    promotion3.Add(new Product("C"), 1);    
    promotion3.Add(new Product("D"), 1);
    
     List<Promotion> promotions = new List<Promotion>(){
                                                                new Promotion(1, promotion1, 130, DateTime.Now.AddDays(-30)),
                                                                new Promotion(2, promotion2, 45, DateTime.Now.AddDays(-20)),
                                                                new Promotion(3, promotion3, 30, DateTime.Now.AddDays(-10)),                                                                
                                                              };

            return promotions;
  }
  
  public static decimal GetDiscountPrice(Order order, Promotion promotion)
  {
      decimal discountPrice = 0;
      
      var productsCount = order.Products
      .GroupBy(x => x.Id)
      .Where(grp => promotion.ActivationDate <= DateTime.Now)
      .Select(grp => grp.Count())
      .Sum();
      
      int promotionProductCount = promotion.Products.Sum(x => x.Value);
      
      decimal promotionAllProductsSum = promotion.Products.Sum(x => x.Value * ((Product)x.Key).UnitPrice);
      while (productsCount >= promotionProductCount)
      {
        discountPrice += promotionAllProductsSum - promotion.PromoPrice;
        productsCount -= promotionProductCount;
      }
       return discountPrice;       
  }
}
}
