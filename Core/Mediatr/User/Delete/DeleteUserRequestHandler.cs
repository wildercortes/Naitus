using Core.Interfaces;
using MediatR;

namespace Core.Mediatr.User.Delete
{
    public class DeleteUserRequestHandler : IRequestHandler<DeleteUserRequest>
    {
        private readonly IUserRepository _userRepository;

        public DeleteUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetById(request.Id);

            await _userRepository.Delete(user);

            return Unit.Value;
        }
    }
}
