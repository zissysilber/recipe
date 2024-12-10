using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook() { }

        private int _cookbookId;
        private int _usersId;
        private string _cookbookname = "";
        private decimal _price;
        private DateTime _dateCreated;
        private bool _isActive;
        private string _cookbookimage;
        private int _cookbookcount;
        private string _cookbookskill;
        private string _usersname;
        private string _recipename;

        //public List<bizCookbook> Search(string cookbooknameval)
        //{
        //    SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
        //    SQLUtility.SetParamValue(cmd, "CookbookName", cookbooknameval);
        //    DataTable dt = SQLUtility.GetDataTable(cmd);
        //    return this.GetListFromDataTable(dt);
        //}

        public List<bizCookbook> SearchCookbook(int cookbookid, string cookbooknameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookSearch");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            SQLUtility.SetParamValue(cmd, "@CookbookName", cookbooknameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int CookbookId
        {
            get => _cookbookId;
            set
            {
                if (_cookbookId != value)
                {
                    _cookbookId = value;
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


        public string CookbookName
        {
            get => _cookbookname;
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get => _dateCreated;
            set
            {
                if (_dateCreated != value)
                {
                    _dateCreated = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CookbookCount
        {
            get => _cookbookcount;
            set
            {
                if (_cookbookcount != value)
                {
                    _cookbookcount = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookSkill
        {
            get => _cookbookskill;
            set
            {
                if (_cookbookskill != value)
                {
                    _cookbookskill = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get => _recipename;
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}


