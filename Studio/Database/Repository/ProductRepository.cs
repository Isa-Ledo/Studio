using Dapper;
using Dapper.Contrib.Extensions;
using Studio.Models.Repository;
using System.Data;

namespace Studio.Database.Repository
{
    public class ProductRepository
    {
        public Connection _connection;

        public ProductRepository(Connection connection)
        {
            _connection = connection;
        }

        public List<ProductEntity> GetProductByCategoryId(int Id)
        {
            using var database = _connection.GetConnection();
            var query = "Select * from Products where CategoryId = @Id";
            var parameters = new DynamicParameters();
            List<ProductEntity> products = new List<ProductEntity>();

            parameters.Add(name: "@Id", value: Id, dbType: DbType.Int32);

            products = database.Query<ProductEntity>(query, parameters).ToList();
            return products;
        }

        public bool SaveProduct(ProductEntity productEntity)
        {
            using var database = _connection.GetConnection();
            return database.Insert(productEntity) == 1;
        }

    }
}
