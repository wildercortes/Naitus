using Core.Mediatr.User.GetById.Response;
using MediatR;

namespace Core.Mediatr.User.GetById
{
    public class GetByIdUserRequest : IRequest<GetByIdUserResponse>
    {
        public int Id { get; set; }
    }
}
