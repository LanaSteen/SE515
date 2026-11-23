using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fitzone.Web.Pages.Member
{
    public class DetailsModel : PageModel
    {

        private readonly IMemberService _memberService;

        public DetailsModel(IMemberService memberService)
		{
			_memberService = memberService;
		}
		public MemberDTO Member { get; set; } = new MemberDTO();
		
    
		public IActionResult OnGet(int id)
        {
			Member = _memberService.GetMemberById(id);
            return Page();
        }
    }
}
