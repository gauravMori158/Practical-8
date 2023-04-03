using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UniversityManagementSystem
{
    sealed class StudentInfo : StudentClass, IStudentInfo
    {            
        /// <summary>
        /// ViewDetail method that is used to provide details of user,
        ///There are two overload method , one will take user id for perticular
        ///User and another one doesn't takes any id , so it will display full information.
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="id"></param>
        /// <returns>Void</returns>
        public void ViewDetail(IUserData userData, int id)
        {

            Dictionary<int, StudentClass> dict = userData.GetDictionary;
            IStudentClass student = FactoryClass.GetStudentInfo();
            try
            {
                student = dict[id];
                Console.WriteLine($"\nName : {student.Name} \nId : {student.Id}\nPhone No : {student.PhoneNo} " +
                    $"\nEmail : {student.Email}\n");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Invalid Student Id or Student with this id is not present .");
            }
        }
        /// <summary>
        /// ViewDetail method that is used to provide details of user,
        ///There are two overload method , one will take user id for perticular
        ///User and another one doesn't takes any id , so it will display full information.
        /// </summary>
        /// <param name="userData"></param>
         
        /// <returns>Void</returns>
        
        
        public void ViewDetail(IUserData userData)
        {

            Dictionary<int, StudentClass> dict = userData.GetDictionary;

            Console.WriteLine("\n\n........All Students...........");

            foreach (KeyValuePair<int, StudentClass> std in dict)
            {
                Console.WriteLine($"\nName : {std.Value.Name} \nId : {std.Key}\nPhone No : {std.Value.PhoneNo} " +
               $"\nEmail : {std.Value.Email}\n");
            }
        }

    }
}
