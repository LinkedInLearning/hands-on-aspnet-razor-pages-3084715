namespace BigStar.Models
{
  public class CollectibleCard
  {

    public int ID { get; set; }
    public string CardName { get; set; }
    public decimal OriginalPrice { get; set; }
    public decimal AskingPrice { get; set; }
    public string ImageURI { get; set; }
    public string Condition { get; set; }
    public bool LimitedEdition { get; set; }

  }
}