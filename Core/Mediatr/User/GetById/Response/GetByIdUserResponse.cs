namespace Core.Mediatr.User.GetById.Response
{
    public  class GetByIdUserResponse
    {
        public int Rut { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
