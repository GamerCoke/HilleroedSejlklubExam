using HSLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HSLibrary.Models;

namespace HilleroedSejlklubExam.Pages.Members
{
    public class ShowMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

<<<<<<< HEAD
        public List<Member> MemberList { get; private set; }
=======
        public int MemberCount => _memberRepository.Count;

        public List<Member> Members { get; private set; }
>>>>>>> k

        public ShowMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public void OnGet()
        {
            MemberList = _memberRepository.GetAll();
        }
    }
    
}
