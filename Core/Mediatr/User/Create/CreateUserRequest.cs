using MediatR;

namespace Core.Mediatr.User.Create
{
    public  class CreateUserRequest : IRequest
    {
        public int Rut { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
