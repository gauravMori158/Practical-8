using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    sealed class Teacher : TeacherAbstract, ITeacher
    {
        /// <summary>
        /// Override user Information can be updated in UpdateStudentInfo Method,
        /// based on user id it will update student information.
        /// </summary>
        /// <param name="userData"></param>

        public override void UpdateStudentInfo(IUserData userData)
        {
            try
            {

                Console.WriteLine("..........Update UserInfo..........");
                Console.WriteLine("Enter User Id : ");

                int id = Convert.ToInt32(Console.ReadLine());
                Dictionary<int, StudentClass> dictionary = userData.GetDictionary;

                Console.WriteLine("Enter The Name You Want to Update");
                dictionary[id].Name = Console.ReadLine();
                Console.WriteLine("Enter The Email You Want to Update");
                dictionary[id].Email = Console.ReadLine();
                Console.WriteLine("Enter The Phone No You Want to Update");
                dictionary[id].PhoneNo = Convert.ToInt64(Console.ReadLine());


                Console.WriteLine("User Updated  Successfully !!!");

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error while updating..... " + ex.Message);
            }

        }

        /// <summary>
        /// Override DeleteUserInfo Method used to delete User information 
        /// based on user Id.
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="id"></param>
        public override void DeleteStudentInfo(IUserData userData, int id)
        {
            Console.Write("Confirm Deletion ... y|n : ");
            char confirm = Console.ReadKey().KeyChar;
            Console.WriteLine();
            confirm.ToString().ToLower();
            if (confirm == 'y')
            {
                Console.WriteLine(" Deleted User  ");
                Dictionary<int, StudentClass> dictionary = userData.GetDictionary;
                Console.WriteLine($"Name : {dictionary[id].Name} \t Id : {id}");
                dictionary.Remove(id);
            }
        }
    }
}
