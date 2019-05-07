using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Shop.Data.Models
{
	public class ApplicationUser:IdentityUser
	{
		public string ImageUrl { get; set; }
		public bool IsActive { get; set; }
		public decimal Balance { get; set; }
		public DateTime MemberSince { get; set; }
		public IEnumerable<Order> Orders { get; set; }
	}
}