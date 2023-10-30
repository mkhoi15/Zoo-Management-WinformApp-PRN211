using Entities.Models;
using FluentValidation;

namespace Entities.Helper
{
	public class ApplicationUserValidationHelper : AbstractValidator<ApplicationUser>
	{
		public ApplicationUserValidationHelper() 
		{
			RuleFor(u => u.FullName).NotNull().NotEmpty();
			RuleFor(u => u.Password).NotNull().NotEmpty();
			RuleFor(u => u.UserName).NotNull().NotEmpty();
			RuleFor(u => u.Email).NotNull().NotEmpty().EmailAddress();
			RuleFor(u => u.PhoneNumber).NotNull().NotEmpty();
			RuleFor(u => u.Dob).NotNull().NotEmpty();
			RuleFor(u => u.Gender).NotNull().NotEmpty();
			RuleFor(u => u.Role).NotNull().NotEmpty();
		}
	}
}
