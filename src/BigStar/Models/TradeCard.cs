using System.ComponentModel.DataAnnotations;
namespace BigStar.Models
{
	public class TradeCard
	{
		[Display(Name = "How many cards?", Prompt = "Number of cards to sell")]
		public int CardCount { get; set; } = 1;
		[Display(Name = "Card Name", Prompt = "Add the card name")]
		public string CardName { get; set; }
		public Condition Condition { get; set; } = Condition.Mint;
	}
}