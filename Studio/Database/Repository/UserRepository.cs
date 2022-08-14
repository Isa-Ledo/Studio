using Dapper;
using Dapper.Contrib.Extensions;
using Studio.Models;
using Studio.Models.Repository;
using System.Data;

namespace Studio.Database.Repository
{
    public class UserRepository
    {
        public Connection _connection;

        public UserRepository(Connection connection)
        {
            _connection = connection;
        }


        public UserEntity GetUserByLogin(LoginModel login)
        {
            using var database = _connection.GetConnection();
            var query = "Select top 1 * from Users where email = @email and password = @password";

            var parameters = new DynamicParameters();
            parameters.Add(name: "@email", value: login.Login, dbType: DbType.String);
            parameters.Add(name: "@password", value: login.Senha, dbType: DbType.String);


            var user = database.QueryFirstOrDefault<UserEntity>(query, parameters);
            return user;
        }

        public bool SaveUser(UserEntity user)
        {
            using var database = _connection.GetConnection();
            return database.Insert(user) == 1;
        }
    }
}
