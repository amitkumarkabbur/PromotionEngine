namespace PromotionEngine
{
  public class Promotion 
  {
    public int Id { get; set;}
    public decimal PromoPrice {get; set;}
    public datetime ActivationDate {get; set;}
    
    public Promotion (int id, decimal, price, datetime date)
    {
      Id = id;
      PromoPrice = price;
      ActivationDate = datetime;
    }    
  }
}
