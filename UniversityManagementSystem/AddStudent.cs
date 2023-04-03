using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UniversityManagementSystem
{
    sealed class AddStudent : IAddStudent
    {
       
        /// <summary>
        ///  AddStudent Method is used to add student based on unique id.
        /// user have Unique id, Name, Phone No and Email.
        /// </summary>
        /// <param name="userData"></param>
        public void AddNewStudent(IUserData userData)
        {
            Dictionary<int, StudentClass> dict = userData.GetDictionary;
            try
            {

                Console.WriteLine("..........Add UserInfo..........");
                Console.WriteLine("Enter Unique Id ");

                int id = Convert.ToInt32(Console.ReadLine());

                Dictionary<int, StudentClass> dictionary = userData.GetDictionary;

                if (dictionary.ContainsKey(id))
                {
                    Console.WriteLine("Id is already present, Please provide unique");
                    id = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter The Name  ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter The Email  ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter The Phone No  ");
                long phoneNo = Convert.ToInt64(Console.ReadLine());
                
                dictionary.Add(id, new StudentClass()
                {
                    Id = id,
                    Name = name,
                    Email = email,
                    PhoneNo = phoneNo
                });
                Console.WriteLine("\n User Added Successfully !!!");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input type formate error ! ");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error : " + Ex.Message);
            }
        }



    }
}
