using AutoMapper;
using FitZone.Application.Services.Implementations;
using FitZone.Domain.Interfaces;
using FitZone.Domain.Models.DTOs.MembersDTOs;
using FitZone.Domain.Models.Entities;
using FitZone.Infrastructure.Data;
using FitZone.Infrastructure.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitZone.Tests
{
	public class FitZoneServicesTests
	{

		private readonly Mock<IMemberRepository> _memberRepository;
		private readonly Mock<IUnitOfWork> _unitOfWork;

		private readonly Mock<IMapper> _mapper;

		private readonly MemberService _memberService;


		public FitZoneServicesTests()
		{
			_memberRepository = new Mock<IMemberRepository>();
			_unitOfWork = new Mock<IUnitOfWork>();
			_mapper = new Mock<IMapper>();
			_memberService = new MemberService(
				_memberRepository.Object,
				_mapper.Object, 
				_unitOfWork.Object);
		}



		[Fact]
		public void AddMember_ShouldCallRepositoryAndUnitOfWork()
		{
			// Arrange
			var createMemberDTO = new CreateMemberDTO
			{
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};
			var memberEntity = new Member
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};


			_mapper.Setup(m => m.Map<Member>(createMemberDTO)).Returns(memberEntity);
			
			// Act
			_memberService.AddMember(createMemberDTO);
			// Assert
			
			_memberRepository.Verify(r => r.AddMember(It.Is<Member>(m =>
				m.FirstName == createMemberDTO.FirstName &&
				m.LastName == createMemberDTO.LastName &&
				m.MembershipTypeId == createMemberDTO.MembershipTypeId)), Times.Once);

			_unitOfWork.Verify(u => u.SaveChanges(), Times.Once);
		}


		[Fact]
		public	void DeleteMember_ShouldCallRepositoryAndUnitOfWork()
		{
			// Arrange
			int memberId = 1;
			var memberEntity = new Member
			{
				Id = memberId,
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};
			_memberRepository.Setup(r => r.GetMemberById(memberId)).Returns(memberEntity);
			// Act
			_memberService.DeleteMember(memberId);
			// Assert
			_memberRepository.Verify(r => r.DeleteMember(It.Is<Member>(m => m.Id == memberId)), Times.Once);
			_unitOfWork.Verify(u => u.SaveChanges(), Times.Once);
		}




		[Fact]
		public void DeleteMember_ShouldThrowException_WhenIdIsInvalid()
		{
			// Arrange
			int memberId = 0;
			_memberRepository.Setup(r => r.GetMemberById(memberId)).Returns((Member)null);

			// Act & Assert

		    var result = Assert.Throws<ArgumentException>(() => _memberService.DeleteMember(memberId));
			Assert.Equal("Id cannot be 0", result.Message);

		}


		[Theory]
		[InlineData(new int[] { 0, -1, -100, int.MinValue })]
		//[InlineData(0)]
		//[InlineData(-1)]
		//[InlineData(-100)]
		//[InlineData(int.MinValue)]
		public void DeleteMember_ShouldThrowException_WhenIdsAreInvalid(int[] invalidIds)
		{
		
			foreach (var item in invalidIds)
			{
				// Arrange

				_memberRepository.Setup(r => r.GetMemberById(item)).Returns((Member)null);
				// Act & Assert
				var result = Assert.Throws<ArgumentException>(() => _memberService.DeleteMember(item));
				Assert.Equal("Id cannot be less than or equal to 0", result.Message);
			}

		}


		[Theory]
		[InlineData(0)]
		[InlineData(-1)]
		[InlineData(-100)]
		[InlineData(int.MinValue)]
		public void DeleteMember_ShouldThrowException_WhenIdsAreInvalidWithMAnyInlineData(int invalidId)
		{
				// Arrange
				_memberRepository.Setup(r => r.GetMemberById(invalidId)).Returns((Member)null);
				// Act & Assert
				var result = Assert.Throws<ArgumentException>(() => _memberService.DeleteMember(invalidId));
				Assert.Equal("Id cannot be less than or equal to 0", result.Message);
		}
	}
}
