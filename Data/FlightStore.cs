using wt_lab5_5razor_sudinko.Models;

namespace wt_lab5_5razor_sudinko.Data;

public static class FlightStore
{
    public static List<Flight> Flights { get; } = new()
    {
        new Flight { Id = 1, Number = "B2-101", From = "Минск", To = "Москва", Price = 150, IsAvailable = true },
        new Flight { Id = 2, Number = "B2-205", From = "Минск", To = "Варшава", Price = 210, IsAvailable = true },
        new Flight { Id = 3, Number = "B2-310", From = "Минск", To = "Стамбул", Price = 340, IsAvailable = false },
        new Flight { Id = 4, Number = "B2-412", From = "Минск", To = "Дубай", Price = 520, IsAvailable = true },
        new Flight { Id = 5, Number = "B2-518", From = "Минск", To = "Санкт-Петербург", Price = 130, IsAvailable = true }
    };
}