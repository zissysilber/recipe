using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeID"];
            string sql = "";
            
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"UsersID = '{r["UsersID"]}',",
                    $"CuisineID = '{r["CuisineID"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = {r["Calories"]},",
                    $"DateDrafted = '{r["DateDrafted"]}'",
                    $"where RecipeID = {r["RecipeID"]}");
            }
            else
            {
                sql = "insert Recipe(UsersID, CuisineID, RecipeName, Calories, DateDrafted)";
                sql += $"select '{r["UsersID"]}', '{r["CuisineID"]}','{r["RecipeName"]}',{r["Calories"]}, '{r["DateDrafted"]}'";
            }

            Debug.Print("_________________");
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "delete recipe where RecipeID = " + id;
            SQLUtility.ExecuteSQL(sql);
        }


        public static DataTable GetUsersList()
        {
            DataTable dt = new();
            SqlConnection conn = new SqlConnection(SQLUtility.ConnectionString);
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlConnection conn = new SqlConnection(SQLUtility.ConnectionString);
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = SQLUtility.GetDataTable("select r.*, c.CuisineName, u.UsersName from Recipe r join Users u on r.UsersID = u.UsersID join Cuisine c on r.CuisineID = c.CuisineID  where r.RecipeID = " + recipeid.ToString());
            return dt;
        }


        
        

    }
}
