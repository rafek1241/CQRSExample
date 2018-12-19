using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CQRSExample.Domain.Models;
using FluentValidation;
using FluentValidation.Results;

namespace CQRSExample.Events.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(w => w.Name).NotEmpty();
            RuleFor(w => w.Id).Equal(0);
            RuleFor(w => w.Products).Empty();
            RuleFor(w => w.Specifications).Empty();
        }
    }
}
