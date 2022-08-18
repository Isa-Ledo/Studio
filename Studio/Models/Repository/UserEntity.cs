using Dapper.Contrib.Extensions;

namespace Studio.Models.Repository
{
    [Table("Users")]
    public class UserEntity
    {
        public UserEntity(int id, string name, string email, string password, DateTime birthDate)
        {
            Id = id;
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
