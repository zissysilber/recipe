using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizMeal : bizObject<bizMeal>
    {
        public bizMeal() { }

        private int _mealId;
        private int _usersId;
        private string _usersname;
        private string _mealname = "";
        private string _mealdesc = "";
        private DateTime _datecreated;
        private bool _isactive;
        private int _mealcount;


        public List<bizMeal> Search(string mealnameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "MealName", mealnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int MealId
        {
            get => _mealId;
            set
            {
                if (_mealId != value)
                {
                    _mealId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UsersId
        {
            get => _usersId;
            set
            {
                if (_usersId != value)
                {
                    _usersId = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UsersName
        {
            get => _usersname;
            set
            {
                if (_usersname != value)
                {
                    _usersname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealName
        {
            get => _mealname;
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealDesc
        {
            get => _mealdesc;
            set
            {
                if (_mealdesc != value)
                {
                    _mealdesc = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get => _datecreated;
            set
            {
                if (_datecreated != value)
                {
                    _datecreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool IsActive
        {
            get => _isactive;
            set
            {
                if (_isactive != value)
                {
                    _isactive = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int MealCount
        {
            get => _mealcount;
            set
            {
                if (_mealcount != value)
                {
                    _mealcount = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
