using Entities.Models;
using FluentValidation;

namespace Entities.Helper
{
	public class CageValidationHelper : AbstractValidator<Cage>
	{
        public CageValidationHelper()
        {
            RuleFor(c => c.CageName).NotNull().NotEmpty();
            RuleFor(c => c.AreaId).NotNull().NotEmpty();
        }
    }
}
