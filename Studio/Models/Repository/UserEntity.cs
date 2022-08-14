using Dapper.Contrib.Extensions;

namespace Studio.Models.Repository
{
    [Table("Users")]
    public class UserEntity
    {
        public UserEntity(string name, string email, string password, DateTime birthDate)
        {
            Name = name;
            Email = email;
            Password = password;
            BirthDate = birthDate;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
