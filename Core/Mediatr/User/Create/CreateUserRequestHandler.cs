using Core.Interfaces;
using MediatR;

namespace Core.Mediatr.User.Create
{
    public class CreateUserRequestHandler : IRequestHandler<CreateUserRequest>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = new Entities.User
            {
                Rut = request.Rut,
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                BirthDate = request.BirthDate
            };

            await _userRepository.Create(user);

            return Unit.Value;
        }
    }
}
