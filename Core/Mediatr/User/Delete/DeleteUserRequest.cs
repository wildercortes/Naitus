using MediatR;

namespace Core.Mediatr.User.Delete
{
    public class DeleteUserRequest : IRequest
    {
        public int Id { get; set; }
    }
}
