using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UniversityManagementSystem
{
    class Execution
    {
      
        public static void Main()
        {
            Console.WriteLine(".......Student Management Portal.........\n\n");
            IUserData userData = FactoryClass.GetUserData();
            Dictionary<int, StudentClass> StudentDictionary = new Dictionary<int, StudentClass>();

            /* Some Default Student */

            StudentDictionary.Add(1, new StudentClass()
            {
                Name = "Mori",
                Id = 1,
                Email = "gkmori@email.com",
                PhoneNo = 9090909090
            });
            StudentDictionary.Add(2, new StudentClass()
            {
                Name = "Gaurav",
                Id = 2,
                Email = "2gkmori@email.com",
                PhoneNo = 2290909090
            });
            StudentDictionary.Add(3, new StudentClass()
            {
                Name = "Gaurav3",
                Id = 3,
                Email = "3gkmori@email.com",
                PhoneNo = 3390909090
            });


            userData.UserDictionary = StudentDictionary;

            IHigherLevelClass levelClass = FactoryClass.GetHigherLevelMethod();
            levelClass.HigherLevelDependent(userData);












        }
    }
}
