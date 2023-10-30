using Entities.Models;
using FluentValidation;

namespace Entities.Helper
{
	public class AnimalValidationHelper : AbstractValidator<Animal>
	{
		public AnimalValidationHelper()
		{
			RuleFor(a => a.AnimalName).NotNull().NotEmpty();
			RuleFor(a => a.Species).NotNull().NotEmpty();
			RuleFor(a => a.CageId).NotEmpty().NotEmpty();
		}
	}
}
