using Core.Interfaces;
using Core.Mediatr.User.GetById.Response;
using MediatR;

namespace Core.Mediatr.User.GetById
{
    public class GetByIdUserRequestHandler : IRequestHandler<GetByIdUserRequest, GetByIdUserResponse>
    {
        private readonly IUserRepository _userRepository;

        public GetByIdUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetById(request.Id);

            var response = new GetByIdUserResponse
            {
                Rut = user.Rut,
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
                BirthDate = user.BirthDate,
                Password = user.Password
            };

            return response;
        }
    }
}
