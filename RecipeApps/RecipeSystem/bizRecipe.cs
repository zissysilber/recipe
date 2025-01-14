using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipe : bizObject <bizRecipe>
    {
        public bizRecipe() { }

        private int _recipeId;
        private int _usersId;
        private string _usersname;
        private int _cuisineId;
        private string _recipename = "";
        private int _calories;
        private int _numingredients;
        private DateTime? _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus;
        private int _recipecount;
        private bool _vegan;
        private List<bizRecipeIngredient> _lstingredient;
        private List<bizRecipeDirection> _lstdirection;
        private string _cuisinename;

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public List<bizRecipe> SearchByCuisine(string cuisinenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "CuisineName", cuisinenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }


        public int RecipeId
        {
            get => _recipeId;
            set
            {
                if (_recipeId != value)
                {
                    _recipeId = value;
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

        public string? UsersName
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

        public string? CuisineName
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

        public int Calories
        {
            get => _calories;
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get => _numingredients;
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateDrafted
        {
            get => _datedrafted;
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DatePublished 
        {
            get => _datepublished;
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        { 
            get => _datearchived;
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string? RecipeStatus
        {
            get => _recipestatus;
            set
            {
                if (_recipestatus!= value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int RecipeCount
        {
            get => _recipecount;
            set
            {
                if (_recipecount != value)
                {
                    _recipecount = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Vegan
        {
            get => _vegan;
            set
            {
                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }

        public List<bizRecipeIngredient> IngredientList
        {
            get
            {
                if (_lstingredient == null)
                {
                    _lstingredient = new bizRecipeIngredient().LoadIngredientByRecipeId(this.RecipeId);
                }
                return _lstingredient;
            }
        }

        public List<bizRecipeDirection> DirectionList
        {
            get
            {
                if (_lstdirection == null)
                {
                    _lstdirection = new bizRecipeDirection().LoadDirectionByRecipeId(this.RecipeId);
                }
                return _lstdirection;
            }
        }
    }
}

