using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_sudinko.Data;
using wt_lab5_5razor_sudinko.Models;

namespace wt_lab5_5razor_sudinko.Pages.Flights;

public class DetailsModel : PageModel
{
    public Flight? Flight { get; set; }

    public IActionResult OnGet(int id)
    {
        Flight = FlightStore.Flights.FirstOrDefault(x => x.Id == id);

        if (Flight == null)
        {
            return NotFound();
        }

        return Page();
    }
}