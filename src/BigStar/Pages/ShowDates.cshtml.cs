using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ShowDatesModel : PageModel
  {
    public IEnumerable<DateOnly> SaleDates { get; set; }
    public void OnGet()
    {
      SaleDates = GetSaleDates(DateOnly.FromDateTime(DateTime.Now));
    }
    private IEnumerable<DateOnly> GetSaleDates(DateOnly startingDate)
    {
      var allDays = AllDatesInMonth(startingDate.Year, startingDate.Month);
      var SaleDays = allDays.Where(x => x.DayOfWeek == DayOfWeek.Monday
                                    || x.DayOfWeek == DayOfWeek.Wednesday);
      return SaleDays;

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
