using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Meal
    {
        public static DataTable GetMealSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
