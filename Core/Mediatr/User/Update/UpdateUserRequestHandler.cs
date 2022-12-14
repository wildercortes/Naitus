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
            var user = await _userRepository.GetById(request.Id);

            if (user == null)
                throw new Exception("User not found");

            user.Rut = request.Rut;
            user.Name = request.Name;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.BirthDate = request.BirthDate;


            await _userRepository.Update(user);

            return Unit.Value;
        }
    }
}
