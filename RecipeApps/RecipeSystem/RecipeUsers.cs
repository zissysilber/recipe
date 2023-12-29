﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class RecipeUsers
    {

        public static DataTable LoadRecipeUsers()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
