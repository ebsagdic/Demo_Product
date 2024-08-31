using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required}");
            RuleFor(x => x.City).NotEmpty().WithMessage("{PropertyName} must be greater 0");
        }

    }
}
