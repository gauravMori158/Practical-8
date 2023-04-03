using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    class StudentClass : IStudentClass
    {


        private string _name;
        private string _email;
        private long _phone;
        private int _id;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                    _id = value;

            }
        }
        public long PhoneNo
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }



    }
}
