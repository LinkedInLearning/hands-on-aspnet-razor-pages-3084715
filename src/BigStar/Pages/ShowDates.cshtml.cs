using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ShowDatesModel : PageModel
  {
    public void OnGet()
    {
    }

    public IEnumerable<DateOnly> AllDatesInMonth(int year, int month)
    {
      int days = DateTime.DaysInMonth(year, month);
      for (int day = 1; day <= days; day++)
      {
        yield return new DateOnly(year, month, day);
      }

    }
  }
}
