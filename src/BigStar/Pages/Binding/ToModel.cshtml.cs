using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{
  [BindProperties(SupportsGet = true)]
  public class ToModelModel : PageModel
  {
    public string CardName { get; set; }
    public decimal? OriginalPrice { get; set; }
    public BigStar.Models.CollectibleCard CurrentCard { get; set; }
    public void OnGet()
    {
    }
  }
}
