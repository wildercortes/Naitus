namespace Entities
{
    public class User
    {
        public int Id { get; set; }

        public int Rut { get; set; }

        public string? Name  { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime BirthDate { get; set; }
       
    }
}
