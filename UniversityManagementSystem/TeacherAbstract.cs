using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    abstract class TeacherAbstract
    {
        public abstract void UpdateStudentInfo(IUserData userData);
        public abstract void DeleteStudentInfo(IUserData userData, int id);

    }
}
