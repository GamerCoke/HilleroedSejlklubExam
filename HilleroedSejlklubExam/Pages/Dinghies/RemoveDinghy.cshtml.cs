<<<<<<< HEAD
using HSLibrary.Interfaces;
using HSLibrary.Models.Dinghy;
using HSLibrary.Models.Dinghy.Motorized;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlklubExam.Pages.Dinghies
{
    public class RemoveDinghyModel : PageModel
    {
        IDinghyRepository _dinghyRepository;
        public RemoveDinghyModel(IDinghyRepository dinghyRepository)
        {
            _dinghyRepository = dinghyRepository;
        }
=======
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlklubExam.Pages.Dinghy
{
    public class RemoveDinghyModel : PageModel
    {
>>>>>>> 21ad11a5980529fd246fb6d2e7660f64a9d0091b
        public void OnGet()
        {
        }
    }
}
