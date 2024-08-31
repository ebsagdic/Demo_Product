using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CateogryValidator:AbstractValidator<Category>
    {
        public CateogryValidator()
        {
            RuleFor(x => x.CategoryName).NotNull().WithMessage("{PropertyName} is required}");
        }
    }
}
