namespace RecipeSystem
{
    public class Cookbook
    {

        
        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetCookbookSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookSummaryGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable LoadRecipebyCookbookId (int cookbookid)
        {

            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookbookSave method because there are no rows in the table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtcookbook)
        {
            int id = (int)dtcookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@cookbookid", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveCookbookRecipeTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static void DeleteCookbookRecipe(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeId"].Value = cookbookrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int GetCookbookIdFromTable(DataTable dt)
        {
            int cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dt, "cookbookid");
            return cookbookid;
        }

        public static DataTable CreateCookbookBasedOnUser(int basedonuserid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookCreate");
            cmd.Parameters["@BasedOnUsersId"].Value = basedonuserid;

            SQLUtility.ExecuteSQL(cmd);
            int newcookbookid = (int)cmd.Parameters["@CookbookId"].Value;
            return dt = Load(newcookbookid);
        }


    }
}
