using System.Data.SqlClient;


namespace Studio.Database
{
    public class Connection
    {
        public SqlConnection GetConnection()
            => new SqlConnection(@"Server=LAPTOP-DRL80GV1\SQLEXPRESS;Database=studio;Trusted_Connection=True;");
    }
}
