using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizUsers: bizObject<bizUsers>
    {
        private int _usersId;
        private string _usersName = "";

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
            get => _usersName;
            set
            {
                if(_usersName != value)
                {
                    _usersName = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
