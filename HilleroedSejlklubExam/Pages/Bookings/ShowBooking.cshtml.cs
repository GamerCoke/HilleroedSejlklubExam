using HSLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HSLibrary.Models.Dinghy;

namespace HilleroedSejlklubExam.Pages.Bookings
{
    public class ShowBookingModel : PageModel
    {
        private IBookingRepository _bookingRepository;

        public List<Booking> BookingList { get; private set; }

        public ShowBookingModel(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public void OnGet()
        {
            BookingList = _bookingRepository.GetAll();
        }
    }

}
