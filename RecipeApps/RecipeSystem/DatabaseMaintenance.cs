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
