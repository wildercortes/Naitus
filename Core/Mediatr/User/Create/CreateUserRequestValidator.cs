using Core.Utils;
using FluentValidation;

namespace Core.Mediatr.User.Create
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(p => p.Name).NotNull().NotEmpty().WithMessage("email is required.");
            RuleFor(p => p.LastName).NotNull().NotEmpty().WithMessage("lastName is required.");
            RuleFor(p => p.Email).NotNull().NotEmpty().EmailAddress().WithMessage("email is required.");
            RuleFor(p => p.Password).NotNull().NotEmpty().WithMessage("password is required.");
            RuleFor(p => p.BirthDate).NotNull().NotEmpty().Must(CommonValidations.BeAValidDate).WithMessage("Invalid birthDate");
        }
    }
}
