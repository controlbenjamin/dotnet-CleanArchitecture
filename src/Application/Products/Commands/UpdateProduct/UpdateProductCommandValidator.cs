using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {

        public UpdateProductCommandValidator()
        {
            RuleFor(v => v.Description)
               .MaximumLength(200)
               .NotEmpty();
        }
    }
}
