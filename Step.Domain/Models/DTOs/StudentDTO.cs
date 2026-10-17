using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Step.Domain.Models.DTOs
{
	public class StudentDTO
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Name { get; set; }

		public override string? ToString()
		{
			return $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Name: {Name}";
		}
	}
}
