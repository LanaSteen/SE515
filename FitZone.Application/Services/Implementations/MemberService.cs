using AutoMapper;
using FitZone.Application.Services.Interfaces;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using FitZone.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Application.Services.Implementations
{
	public class MemberService : IMemberService
	{
		private readonly IMemberRepository _memberRepository;
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public MemberService(IMemberRepository memberRepository,
			IMapper mapper, IUnitOfWork unitOfWork)
		{
			_memberRepository = memberRepository;
			_mapper = mapper;
			_unitOfWork = unitOfWork;
				
		}


		public void AddMember(CreateMemberDTO member)
		{

			// AutoMApper 

			//manual mapping
			//var newMembeer = new Member();
			//newMembeer.FirstName = member.FirstName;
			//newMembeer.LastName = member.LastName;
			//newMembeer.MembershipTypeId = member.MembershipTypeId;


			var newMember = _mapper.Map<Member>(member);

		    _memberRepository.AddMember(newMember);
			_unitOfWork.SaveChanges();

		}

		public void	DeleteMember(int Id)
		{
			if(Id <=0)
			{
				throw new ArgumentException("Id cannot be less than or equal to 0");
			}
			Member memb = _memberRepository.GetMemberById(Id);
			if (memb == null)
			{
				throw new ArgumentException("Member not found");
			}

			_memberRepository.DeleteMember(memb);
			_unitOfWork.SaveChanges();
		}

		public List<MemberDTO> GetAllMembers()
		{
			var members = _memberRepository.GetAllMembers();
			if (members == null || members.Count == 0)
			{
				throw new ArgumentException("No members found");
			}
			var membersDTO = _mapper.Map<List<MemberDTO>>(members);
			return membersDTO;
		}

		public MemberDTO GetMemberById(int Id)
		{
			if(Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}
			Member memb = _memberRepository.GetMemberById(Id);
			if (memb == null)
			{
				throw new ArgumentException("Member not found");
			}
			var memberDTO = _mapper.Map<MemberDTO>(memb);
			return memberDTO;
		}

		public void UpdateMember(UpdateMemberDTO member)
		{
			if(member == null)
			{
				throw new ArgumentException("Member cannot be null");
			}
			if(member.Id == 0)
			{
				throw new ArgumentException("Id cannot be 0");
			}

			var updatedMember = _mapper.Map<Member>(member);
			_memberRepository.UpdateMember(updatedMember);
			_unitOfWork.SaveChanges();
		}
	}
}
