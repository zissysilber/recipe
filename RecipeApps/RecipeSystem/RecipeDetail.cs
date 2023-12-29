using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
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



        //public static DataTable GetRecipeDirection()
        //{
        //    DataTable dt = DataMaintenance.GetDataList("RecipeDirection");
        //    return dt;
        //}


        //public static void SaveTable(DataTable dt, int presidentid)
        //{
        //    foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
        //    {
        //        r["PresidentId"] = presidentid;
        //    }
        //    SQLUtility.SaveDataTable(dt, "PresidentMedalUpdate");
        //}

        //public static void Delete(int presidentmedalid)
        //{
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("PresidentMedalDelete");
        //    cmd.Parameters["@PresidentMedalID"].Value = presidentmedalid;
        //    SQLUtility.ExecuteSQL(cmd);
        //}

    }
}
