﻿using System.Data;
using System.Data.SqlClient;



namespace RecipeSystem
{
    public class Recipe
    {

        public static DataTable SearchRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipename"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave method because there are no rows in the table");
            }
            
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");

        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@recipeid", id);
            SQLUtility.ExecuteSQL(cmd);
        }


        public static DataTable GetUsersList()
        {
            DataTable dt = new();
            
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
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


        
        

    }
}
