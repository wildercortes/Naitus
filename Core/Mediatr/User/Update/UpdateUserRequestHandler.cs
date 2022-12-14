using Core.Interfaces;
using MediatR;

namespace Core.Mediatr.User.Update
{
    public class UpdateUserRequestHandler : IRequestHandler<UpdateUserRequest>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
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

            await _userRepository.Update(user);

            return Unit.Value;
        }
    }
}
