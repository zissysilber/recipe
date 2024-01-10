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
