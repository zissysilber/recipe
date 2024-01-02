using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Users
    {
        public static DataTable GetUsersList()
        {
            

            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

    }
}
