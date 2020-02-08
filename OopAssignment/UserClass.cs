using System;
namespace OopAssignment
{
    public class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
