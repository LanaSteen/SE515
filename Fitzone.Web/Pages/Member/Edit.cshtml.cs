using AutoMapper;
using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace Fitzone.Web.Pages.Member
{
    public class EditModel : PageModel
    {

        private readonly IMemberService _memberService;
        private readonly IMapper _mapper;

        public EditModel(IMemberService memberService, IMapper mapper)
		{
			_memberService = memberService;
			_mapper = mapper;
		}

        [BindProperty]
        public UpdateMemberDTO Member { get; set; } = new UpdateMemberDTO();

		public IActionResult OnGet(int id)
        {
			var member = _memberService.GetMemberById(id);
            Member = _mapper.Map<UpdateMemberDTO>(member);

			if (member == null)
            {
                return NotFound();
            }

            return Page();
        }




        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
				return Page();

			}
			_memberService.UpdateMember(Member);
			return RedirectToPage("Index");
		}




    }
}
