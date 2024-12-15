using HSLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
=======
using HSLibrary.Models;
using HSLibrary.Interfaces;
>>>>>>> k
using HSLibrary.Models.Dinghy;

namespace HilleroedSejlklubExam.Pages.Bookings
{
    public class ShowBookingModel : PageModel
    {
        private IBookingRepository _bookingRepository;
<<<<<<< HEAD

        public List<Booking> BookingList { get; private set; }

        public ShowBookingModel(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
=======
        public List<Booking> Bookings  { get; private set; }
        //public Show
>>>>>>> k
        public void OnGet()
        {
            BookingList = _bookingRepository.GetAll();
        }
    }

}
