using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_sudinko.Data;
using wt_lab5_5razor_sudinko.Models;

namespace wt_lab5_5razor_sudinko.Pages.Flights;

public class IndexModel : PageModel
{
    public List<Flight> Flights { get; set; } = new();

    public void OnGet()
    {
        Flights = FlightStore.Flights;
    }
}