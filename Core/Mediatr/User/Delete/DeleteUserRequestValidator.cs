using FluentValidation;

namespace Core.Mediatr.User.Delete
{
    public class DeleteUserRequestValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserRequestValidator()
        {
            RuleFor(p => p.Id).NotNull().GreaterThan(0);
        }
    }
}
