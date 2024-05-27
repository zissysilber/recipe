namespace RecipeSystem
{
    public class Recipe
    {

        public static DataTable SearchRecipeByName(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@RecipeName", recipename);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static bool Save(DataTable dtrecipe)
        {
            bool b = false;
            
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave method because there are no rows in the table");
            }
                DataRow r = dtrecipe.Rows[0];
                SQLUtility.SaveDataRow(r, "RecipeUpdate");
                b = true;

            return b;
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@recipeid", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable CloneRecipeBasedOnId(int basedonrecipeid)
        {

            int newrecipeid = 0;
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeClone");
            cmd.Parameters["@BasedOnRecipeId"].Value = basedonrecipeid;
            
            SQLUtility.ExecuteSQL(cmd);

            newrecipeid =  (int)cmd.Parameters["@RecipeId"].Value;
            return dt = Load(newrecipeid);
   
        }

        public static int GetRecipeIdFromTable(DataTable dt)
        {
            int recipeid =  SQLUtility.GetValueFromFirstRowAsInt(dt, "recipeid");
            return recipeid;
        }

        public static DataTable GetRecipeSummary()
        {
            DataTable dt = DataMaintenance.GetDataList("RecipeSummary");
            return dt; 
        }

        public static void UpdateStatus(DataTable dtrecipe, string columnname)
        {
            try
            {
                string newdate = SetCurrentDateAsValue(dtrecipe, columnname).ToString();
                DataRow r = dtrecipe.Rows[0];
                r[columnname] = newdate;
                SQLUtility.SaveDataRow(r, "RecipeUpdate");
            }
            catch (SqlException ex)
            {
                string msg = SQLUtility.ParseConstraintMsg(ex.Message);
                throw new Exception(msg);
            }
        }

        public static DateTime SetCurrentDateAsValue(DataTable dt,  string columnname)
        {
            DateTime date = DateTime.Now;
            dt.Rows[0][columnname] = date;

            return date;
        }

    
    }
}
