using System.Collections.Generic;

namespace PromotionEngine
{
  public class Order
  {
    public int Id { get; set; }
    public List<Product> Products { get; set; }

    public Order(int id, List<Product> products)
    {
        this.Id = id;
        this.Products = products;
    }
  }
}
