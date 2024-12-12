using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HSLibrary.Interfaces;
using HSLibrary.Models.Dinghy;

namespace HilleroedSejlklubExam.Pages.Bookings
{
    public class AddBookingModel : PageModel
    {
        private IBookingRepository _repo;
        private IWebHostEnvironment _environment;

        [BindProperty]
        public Booking Booking { get; set; }

        public AddBookingModel(IBookingRepository repo, IWebHostEnvironment environment)
        {
            _repo = repo;
            _environment = environment;
        }
<<<<<<< HEAD
=======


>>>>>>> bec08ba61bc22e6c48a6111e2c39419564383dfb
        public void OnGet()
        {
        }
    }
}
<<<<<<< HEAD
=======

>>>>>>> bec08ba61bc22e6c48a6111e2c39419564383dfb
