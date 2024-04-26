using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace User
{
    public static class DataBase
    {
        public static string ConnectionDatabase(string dataSource, string initialCatalog, bool serverCertificate)
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            sqlConnectionString.InitialCatalog = initialCatalog;
            sqlConnectionString.DataSource = dataSource;
            sqlConnectionString.IntegratedSecurity = serverCertificate;
            return sqlConnectionString.ConnectionString.ToString();
        }
    }
}
