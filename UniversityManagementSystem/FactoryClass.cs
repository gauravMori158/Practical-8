using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace UniversityManagementSystem
{
    /// <summary>
    /// Factory Class Provides Instance of the Classes 
    ///it used to make application loosely coupled.
    /// </summary>
        
     static  class FactoryClass  
    {
        public static  UserData GetUserData()
        {
            return new UserData();
        }

        public static  StudentInfo GetStudentInfo()
        {
            return new StudentInfo();
        }

        public static  AddStudent GetAddStudent()
        {
            return new AddStudent();
        }

        public static  Teacher GetTeacher()
        {
            return new Teacher();
        }

        public static  HigherLevelClass GetHigherLevelMethod()
        {
            return new HigherLevelClass();
        }

       
    }
}
