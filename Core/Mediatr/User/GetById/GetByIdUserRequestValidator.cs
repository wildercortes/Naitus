using FluentValidation;

namespace Core.Mediatr.User.GetById
{
    public class GetByIdUserRequestValidator : AbstractValidator<GetByIdUserRequest>
    {
        public GetByIdUserRequestValidator()
        {
            RuleFor(p => p.Id).NotNull().GreaterThan(0);
        }
    }
}
