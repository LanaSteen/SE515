using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fitzone.Web.Pages.Member
{
    public class IndexModel : PageModel
    {

        private readonly IMemberService _memberService;

		public IndexModel(IMemberService memberService)
		{
			_memberService = memberService;
		}

        public List<MemberDTO> Members { get; set; } = new List<MemberDTO>();

		public void OnGet()
        {
            Members = _memberService.GetAllMembers();
        }
    }
}
