using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserTask.Library.Entity.ViewModel
{
	public class LoginViewModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }


		[Display(Name = "Remember Me")]
		public bool RememberMe { get; set; }
		[Required]
		[DataType(DataType.Password)]

		public string Password { get; set; }
		public string ReturnUrl { get; set; }

		// AuthenticationScheme is in Microsoft.AspNetCore.Authentication namespace
		//public IList<AuthenticationScheme> ExternalLogins { get; set; }
	}
}
