using FitZone.Domain.Models.Entities;
using FitZone.Infrastructure.Data;
using FitZone.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Internal;

namespace FitZone.Tests
{
	public class FitZoneRepositoryTests
	{

		private FitZoneDbContext CreateContext()
		{
			var options = new DbContextOptionsBuilder<FitZoneDbContext>()
			.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // DDFGHFGD4545F4F5
			.Options;
			return new FitZoneDbContext(options);

		}


		[Fact]
		public void AddMember_ShouldAddMemberToDatabase()
		{
			// Arrange
			var context = CreateContext();
			var repository = new MemberRepository(context);
			var member = new Member
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};
			// Act
			repository.AddMember(member);
			context.SaveChanges();
			// Assert
			var addedMember = context.Members.Find(1);
			Assert.NotNull(addedMember);
			Assert.Equal("John", addedMember.FirstName);
			Assert.Equal("Doe", addedMember.LastName);
			Assert.Equal(1, addedMember.MembershipTypeId);
		}


		[Fact]
		public void GetAllMembers_ShouldReturnAllMembersFromDatabase()
		{
			// Arrange
			var context = CreateContext();
			var repository = new MemberRepository(context);
			var member1 = new Member
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};
			var member2 = new Member
			{
				Id = 2,
				FirstName = "Jane",
				LastName = "Smith",
				MembershipTypeId = 2
			};
			repository.AddMember(member1);
			repository.AddMember(member2);
			context.SaveChanges();
			// Act
			var members = repository.GetAllMembers();
			// Assert
			Assert.Equal(2, members.Count);
		}


		[Fact]
		public void DeleteMember_ShouldRemoveMemberFromDatabase()
		{
			// Arrange
			var context = CreateContext();
			var repository = new MemberRepository(context);
			var member = new Member
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe",
				MembershipTypeId = 1
			};
			repository.AddMember(member);
			context.SaveChanges();
			// Act
			repository.DeleteMember(member);
			context.SaveChanges();
			// Assert
			var deletedMember = context.Members.Find(1);
			Assert.Null(deletedMember);

		}

	}
}
