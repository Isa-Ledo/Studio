using System.Data.SqlClient;


namespace Studio.Database
{
    public class Connection
    {
        public SqlConnection GetConnection()
            => new SqlConnection(@"Server=DESKTOP-NJMIRN7\SQLEXPRESS;Database=Studio;Trusted_Connection=True;");
    }
}
