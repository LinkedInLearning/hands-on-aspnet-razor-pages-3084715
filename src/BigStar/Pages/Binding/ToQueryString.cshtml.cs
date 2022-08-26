using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{
  [BindProperties(SupportsGet = true)]
  public class ToQueryStringModel : PageModel
  {

    public string CardName { get; set; }
    public decimal? OriginalPrice { get; set; }
    public void OnGet()
    {
      if (string.IsNullOrWhiteSpace(CardName))
      {

        CardName = "No CardName found!";
      }
    }
  }
}
