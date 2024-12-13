using HSLibrary.Interfaces;
using HSLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlklubExam.Pages.Members
{
    public class DeleteMemberModel : PageModel
    {
        private IMemberRepository _repo;

        [BindProperty]
        public Member Member { get; set; }

        public DeleteMemberModel(IMemberRepository memberRepository)
        {
            _repo = memberRepository;
        }

        public void OnGet(int deleteid)
        {
            Member = _repo.Get(deleteid);
        }

        public IActionResult OnPost()
        {
            _repo.Remove(Member.Id);
            return RedirectToPage("/Members/ShowMembers");
        }
    }
}
