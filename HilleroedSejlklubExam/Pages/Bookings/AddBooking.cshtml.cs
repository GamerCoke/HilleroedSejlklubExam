using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD

namespace HilleroedSejlklubExam.Pages.Members
{
    public class AddMemberModel : PageModel
    {
=======
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

>>>>>>> 582bf631ebbc1aff1f7ead12154f7a9dda9a93bb
        public void OnGet()
        {
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 582bf631ebbc1aff1f7ead12154f7a9dda9a93bb
