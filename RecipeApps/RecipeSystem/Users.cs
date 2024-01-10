namespace RecipeSystem
{
    public class Users
    {
        public static DataTable GetUsersList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 1;
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

    }
}
