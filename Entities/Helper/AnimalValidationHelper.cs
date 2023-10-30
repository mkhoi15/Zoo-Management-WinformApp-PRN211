using Entities.Models;
using FluentValidation;

namespace Entities.Helper
{
	public class AnimalValidationHelper : AbstractValidator<Animal>
	{
		public AnimalValidationHelper()
		{
			RuleFor(a => a.AnimalName).NotNull().NotEmpty().WithMessage("Animal's name can not be empty!");
			RuleFor(a => a.Species).NotNull().NotEmpty().WithMessage("Species can not be empty!");
			RuleFor(a => a.CageId).NotEmpty().NotEmpty().WithMessage("Cage can not be empty!");
		}
	}
}
