using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{

  [BindProperties(SupportsGet = true)]
  public class ToMethodModel : PageModel
  {

    public string Message { get; set; } = "No message.";
    public void OnGet(BigStar.Models.CollectibleCard currentCard)
    {
      Message = $"This {currentCard.CardName} card is in {currentCard.Condition} condition";
    }
  }
}
