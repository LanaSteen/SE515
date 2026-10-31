using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Services.Implementations
{
	public class MemberService : IMemberService
	{
		private readonly IMemberRepository _memberRepository;

		public MemberService(IMemberRepository memberRepository)
		{
			_memberRepository = memberRepository;
		}


		void IMemberService.AddMember(CreateMemberDTO member)
		{

			// AutoMApper 

			//_memberRepository.AddMember(member);
			throw new NotImplementedException();
		}

		void IMemberService.DeleteMember(int Id)
		{
			throw new NotImplementedException();
		}

		List<MemberDTO> IMemberService.GetAllMembers()
		{
			throw new NotImplementedException();
		}

		MemberDTO IMemberService.GetMemberById(int Id)
		{
			throw new NotImplementedException();
		}

		void IMemberService.UpdateMember(UpdateMemberDTO member)
		{
			throw new NotImplementedException();
		}
	}
}
