using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BigStar.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BigStar.Pages.Forms
{
	[BindProperties]
	public class PriceYourCardsModel : PageModel
	{
		public TradeCard Card { get; set; }
		public string Message { get; set; } = "No card found!";
		public List<SelectListItem> CardItems { get; set; }
		public String CardName { get; set; }

		public void SetupLists()
		{
			var orderedCards = new CardSource().CardsOrderedByName;
			CardItems = orderedCards.Select(x => new SelectListItem(text: x.CardName, value: x.CardName)).ToList();
		}
		public void OnGet()
		{
			SetupLists();
		}
		public void OnPost()
		{
			SetupLists();

			// var offerPrice = 12.50 * Card.CardCount;
			var newCard = new CardSource().CollectibleCards.Where(x => x.CardName == CardName).First();
			var offerPrice = CardSource.GetOfferPrice(CardName, Condition.Good);
			Message = $"Our offer for {Card.CardCount} {newCard.CardName} card(s) in {Card.Condition} condition = {(offerPrice):C} USD ";
		}
	}
}
