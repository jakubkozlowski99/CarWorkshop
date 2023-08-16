using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Commands.EditCarWorkshop
{
    public class EditCarWorkshopCommandValidator : AbstractValidator<EditCarWorkshopCommand>
    {
        public EditCarWorkshopCommandValidator()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("Please enter description");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Please enter phone number")
                .MinimumLength(8).WithMessage("Phone number should have atleast 8 characters")
                .MaximumLength(12).WithMessage("Phone number should maximum of 12 characters");
        }
    }
}
