using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_sudinko.Data;
using wt_lab5_5razor_sudinko.Models;

namespace wt_lab5_5razor_sudinko.Pages.Flights;

public class DeleteModel : PageModel
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

    public IActionResult OnPost(int id)
    {
        var flight = FlightStore.Flights.FirstOrDefault(x => x.Id == id);

        if (flight != null)
        {
            FlightStore.Flights.Remove(flight);
        }

        return RedirectToPage("./Index");
    }
}