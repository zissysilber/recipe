using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //if (dt.Rows.Count == 0)
            //{
            //    throw new Exception("This user has no saved recipes. System cannot compile cookbook.");
            //}
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

        //public static DataTable GetCookbookbyId (int cookbookid)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
        //    cmd.Parameters["@CookbookId"].Value = cookbookid;
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookbookSave method because there are no rows in the table");
            }

            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");

        }

        public static void SaveCookbookRecipeTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added | DataViewRowState.ModifiedCurrent))
            {
                r["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
        }

        public static int GetCookbookIdFromTable(DataTable dt)
        {
            int cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dt, "cookbookid");
            return cookbookid;
        }

        public static DataTable CreateCookbookBasedOnUser(int basedonuserid)
        {
            
            int newcookbookid = 0;
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookCreate");
            cmd.Parameters["@BasedOnUsersId"].Value = basedonuserid;

            SQLUtility.ExecuteSQL(cmd);
            

            newcookbookid = (int)cmd.Parameters["@CookbookId"].Value;
            return dt = Load(newcookbookid);
        }
    }
}
