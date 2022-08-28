using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{

  [BindProperties(SupportsGet = true)]
  public class ToMethodModel : PageModel
  {

    public void OnGet()
    {
    }
  }
}
