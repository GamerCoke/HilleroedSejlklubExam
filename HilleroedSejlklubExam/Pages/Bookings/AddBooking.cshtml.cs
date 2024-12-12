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


        public void OnGet()
        {
        }
    }
}

