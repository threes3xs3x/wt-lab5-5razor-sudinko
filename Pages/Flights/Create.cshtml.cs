using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_sudinko.Data;
using wt_lab5_5razor_sudinko.Models;

namespace wt_lab5_5razor_sudinko.Pages.Flights;

public class CreateModel : PageModel
{
    [BindProperty]
    public Flight Flight { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
                if (!ModelState.IsValid)
        {
            return Page();
        }
        
        Flight.Id = FlightStore.Flights.Any()
            ? FlightStore.Flights.Max(x => x.Id) + 1
            : 1;

        FlightStore.Flights.Add(Flight);

        return RedirectToPage("./Index");
    }
}