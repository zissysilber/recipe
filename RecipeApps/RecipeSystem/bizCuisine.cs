using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCuisine:bizObject <bizCuisine>
    {
        private int _cuisineId;
        private string _cuisinename = "";

        public bizCuisine() { }
        
        public List<bizCuisine> Search(string cuisinenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "CuisineName", cuisinenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int CuisineId
        {
            get => _cuisineId;
            set
            {
                if (_cuisineId != value)
                {
                    _cuisineId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CuisineName
        {
            get => _cuisinename;
            set
            {
                if (_cuisinename != value)
                {
                    _cuisinename = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
