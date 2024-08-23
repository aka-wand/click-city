using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCity.Domain.Entities.Validators
{
    internal class WorkplaceValidator : AbstractValidator<Workplace>
    {
        public WorkplaceValidator()
        {
            RuleFor(w => w.Name).NotEmpty().MaximumLength(120);
        }
    }
}