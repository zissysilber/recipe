using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipeDirection:bizObject <bizRecipeDirection>
    {
        private int _directionsequence;
        private string _directiondesc = "";


        public List<bizRecipeDirection> LoadDirectionByRecipeId(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            var dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }


        public int DirectionSequence
        {
            get { return _directionsequence; }
            set
            {
                if (_directionsequence != value)
                {
                    _directionsequence = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string DirectionDesc
        {
            get { return _directiondesc; }
            set
            {
                if (_directiondesc != value)
                {
                    _directiondesc = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
