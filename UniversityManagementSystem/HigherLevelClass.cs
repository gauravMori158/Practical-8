using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem
{
    sealed class HigherLevelClass : IHigherLevelClass
    {
        enum Option
        {
            ViewAllUser = 1,
            ViewUser = 2,
            RemoveUser = 5,
            AddUser = 3,
            UpdateUser = 4,
            Exit = 6
        }


        /// <summary>
        /// HigherLevelDependent Method That takes IDataUser Interface Reference
        /// and Display some functionality option.
        ///Using Switch case base on Option user can Perform some crud operation.
        /// </summary>
        /// <param name="userData"></param>
        /// <returns>void</returns>>
        public void HigherLevelDependent(IUserData userData)
        {
        

            while (true)
            {

                Console.WriteLine("Choose Option : \n1.View All User \n2.View User\n3.Add User" +
                "\n4.Update User\n5.Remove User\n6.Exit");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());


                    IStudentInfo student = FactoryClass.GetStudentInfo();
                    IAddStudent addStudent = FactoryClass.GetAddStudent();

                    ITeacher teacher = FactoryClass.GetTeacher();



                    switch (option)
                    {
                        case (int)Option.ViewAllUser:
                            student.ViewDetail(userData);
                            break;

                        case (int)Option.ViewUser:
                            Console.WriteLine("Enter user Id you want to See !");
                            int id = Convert.ToInt32(Console.ReadLine());
                            student.ViewDetail(userData, id);
                            break;

                        case (int)Option.AddUser:
                            addStudent.AddNewStudent(userData);
                            break;

                        case (int)Option.RemoveUser:
                            Console.WriteLine("Enter user Id you want Remove !");
                            id = Convert.ToInt32(Console.ReadLine());
                            teacher.DeleteStudentInfo(userData, id);
                            break;

                        case (int)Option.UpdateUser:
                            teacher.UpdateStudentInfo(userData);
                            break;

                        case (int)Option.Exit:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please Check The Option ! ");
                            break;
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }
        }
    }
}
