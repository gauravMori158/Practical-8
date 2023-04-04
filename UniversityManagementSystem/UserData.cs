using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    sealed class UserData : IUserData
    {
        private Dictionary<int, StudentClass> _studentData = new Dictionary<int, StudentClass>();
        public Dictionary<int, StudentClass> UserDictionary
        {
            get
            {
                return _studentData;
            }
            set
            {

                _studentData = value;
            }

        }
    }
}
