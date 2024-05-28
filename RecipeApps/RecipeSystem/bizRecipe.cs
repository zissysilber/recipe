using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipe : bizObject
    {
        public bizRecipe()
        {
        }
        private int _recipeId;
        private int _usersId;
        private int _cuisineId;
        private string _recipename = "";
        private int _calories;
        private int _recipeingredientId;
        private DateTime _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private string _recipestatus;

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

        public DateTime DateDrafted
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

        public string RecipeStatus
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
    }
}

