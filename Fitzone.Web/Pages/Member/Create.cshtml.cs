using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fitzone.Web.Pages.Member
{
    public class CreateModel : PageModel
    {
		private readonly IMemberService _memberService;
	    //private readonly ITrainerService _trainerService;

		public CreateModel(IMemberService memberService)
		{
			_memberService = memberService;
		}

		[BindProperty]
		public CreateMemberDTO Member { get; set; } = new CreateMemberDTO();


		public void OnGet()
        {
			// todo get treinerList
        }


		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_memberService.AddMember(Member);
			return RedirectToPage("Index");

		}



	}
}
