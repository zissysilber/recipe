using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RecipeSystem
{
    public class Recipe
    {

        public static DataTable SearchRecipes(string recipename)
        {
            DataTable dt = SQLUtility.GetDataTable("select RecipeID, RecipeName from Recipe r where r.RecipeName like '%" + recipename + "%'");
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
                    $"UserID = '{r["UserID"]}',",
                    $"CuisineID = '{r["CuisineID"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDrafted= '{r["DateDrafted"]}',",
                    $"DatePublished = '{r["DatePublished"]}',",
                    $"DateArchived= '{r["DateArchived"]}'",
                    $"where RecipeID = {r["RecipeID"]} ");
            }
            else
            {
                sql = "insert Recipe(UserID, CuisineID, RecipeName, Calories, DateDrafted, DateArchived, DatePublished)";
                sql += $"select '{r["UserID"]}', '{r["CuisineID"]}','{r["RecipeName"]}',{r["Calories"]},'{r["DateDrafted"]}','{r["DateArchived"]}','{r["DatePublished"]}'";
            }

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
            DataTable dt = SQLUtility.GetDataTable("select UserID, Username from Users");
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from Cuisine");
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = SQLUtility.GetDataTable("select r.*, c.CuisineName, u.UserName from Recipe r join Users u on r.UserID = u.UserID join Cuisine c on r.CuisineID = c.CuisineID  where r.RecipeID = " + recipeid.ToString());
            return dt;
        }


        
        

    }
}
