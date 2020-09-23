using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {

        public CreateProductCommandValidator()
        {
            RuleFor(v => v.Description)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
