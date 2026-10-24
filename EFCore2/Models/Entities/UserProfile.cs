using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore2.Models.Entities
{
	internal class UserProfile
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateTime { get; set; }

		public int UserId { get; set; }  // fk
		public User User { get; set; }  // navigation property


	}
}


//  1. ცხრილი 
//	2. ენთითი
//	3. ბევრი დტო
//	4. მაპერი 
//	5. რეპოზიტორი
//	5.1 .1. ინტერფეისი
//	6. სერვისი
//	6.1. ინტერფეისი