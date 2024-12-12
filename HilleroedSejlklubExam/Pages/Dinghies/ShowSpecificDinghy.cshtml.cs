using HSLibrary.Interfaces;
using HSLibrary.Models.Dinghy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlklubExam.Pages.Dinghies
{
    public class ShowSpecificDinghyModel : PageModel
    {
        IDinghyRepository _dinghyRepository;
        public Dinghy Dinghy;
        public ShowSpecificDinghyModel(IDinghyRepository dinghyRepository)
        {
            _dinghyRepository = dinghyRepository;
        }
        public void OnGet(int showId)
        {
            Dinghy = _dinghyRepository.Get(showId);
        }
    }
}
