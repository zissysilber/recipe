using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipeIngredient : bizObject <bizRecipeIngredient>
    {
        private int _ingredientId;
        private string _ingredientname = "";
        private string _ingredientimage = "";
        private string _measurementname = "";
        private decimal _measurementamt;

        public List<bizRecipeIngredient> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "IngredientName", ingredientnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public List<bizRecipeIngredient>LoadIngredientByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }



        public int IngredientId
        {
            get { return _ingredientId; }
            set
            {
                if (_ingredientId!= value)
                {
                    _ingredientId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get { return _ingredientname; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname= value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MeasurementName
        {
            get { return _measurementname; }
            set
            {
                if (_measurementname != value)
                {
                    _measurementname = value;
                    InvokePropertyChanged();
                }
            }
        } 

        public string IngredientImage
        {
            get { return _ingredientimage; }
            set
            {
                if (_ingredientimage!= value)
                {
                    _ingredientimage = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal MeasurementAmt
        {
            get { return _measurementamt; }
            set
            {
                if (_measurementamt != value)
                {
                    _measurementamt = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
