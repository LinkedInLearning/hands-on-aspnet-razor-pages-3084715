using System.ComponentModel.DataAnnotations;
namespace BigStar.Models
{
	public class TradeCard
	{
		public int CardCount { get; set; } = 1;
		public string CardName { get; set; }
		public Condition Condition { get; set; } = Condition.Mint;
	}
}