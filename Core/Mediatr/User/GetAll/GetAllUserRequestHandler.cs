using Core.Interfaces;
using Core.Mediatr.User.GetAll.Response;
using MediatR;

namespace Core.Mediatr.User.GetAll
{
    public class GetAllUserRequestHandler : IRequestHandler<GetAllUserRequest, IList<GetAllUserResponse>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IList<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var users = (await _userRepository.GetAll()).Select(x => new GetAllUserResponse
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                Email = x.Email,
                Rut = x.Rut,
                BirthDate = x.BirthDate,
                Password = x.Password
            }).ToList();

            return users;
        }
    }
}
