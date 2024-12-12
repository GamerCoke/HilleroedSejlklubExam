using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HSLibrary.Models;
using HSLibrary.Interfaces;

namespace HilleroedSejlklubExam.Pages.Bookings
{
    public class ShowBookingModel : PageModel
    {
<<<<<<< HEAD
        private IBookingRepository _bookingRepository;
        public List<Booking> Booking  { get; private set; }
        public Show
        public void OnGet()
        {
            Bookings = _bookingRepository.GetAll();
        }
=======
        //private IBookingRepository _bookingRepository;
        //public List<Booking> Bookings  { get; private set; }
        //public Show
        //public void OnGet()
        //{
        //    Bookings = _bookingRepository.GetAll();
        //}
>>>>>>> 1dd468be58036fdbc09368c86dfe5eacd680e12f
    }
}
