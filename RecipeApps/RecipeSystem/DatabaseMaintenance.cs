using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class DatabaseMaintenance
    {

        public static DataTable GetDatabaseSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("SummaryDatabaseGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
