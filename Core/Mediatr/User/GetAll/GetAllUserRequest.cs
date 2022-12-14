using Core.Mediatr.User.GetAll.Response;
using MediatR;

namespace Core.Mediatr.User.GetAll
{
    public class GetAllUserRequest : IRequest<IList<GetAllUserResponse>>
    {
    }
}
