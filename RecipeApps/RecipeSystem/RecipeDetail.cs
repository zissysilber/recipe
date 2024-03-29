﻿namespace RecipeSystem
{
    public class RecipeDetail
    {
        public static DataTable LoadIngredientByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadRecipeDirectionByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveRecipeIngredientTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }

        public static void SaveRecipeDirectionTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeDirectionUpdate");
        }

        public static void DeleteRecipeDirectionRow (int recipedirectionid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionDelete");
            cmd.Parameters["@RecipeDirectionId"].Value = recipedirectionid;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void DeleteRecipeIngredientRow(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientDelete");
            cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }



    }
}
