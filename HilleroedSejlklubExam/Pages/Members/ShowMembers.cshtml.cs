using HSLibrary.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HSLibrary.Models;

namespace HilleroedSejlklubExam.Pages.Members
{
    public class ShowMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        public List<Member> Members { get; private set; }

        public ShowMembersModel(IMemberRepository customerRepository)
        {
            _memberRepository = customerRepository;
        }
        public void OnGet()
        {
            Member = _memberRepository.GetAll();
        }
    }
    
}
