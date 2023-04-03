namespace UniversityManagementSystem
{
    internal interface ITeacher
    {
        void DeleteStudentInfo(IUserData userData, int id);
        void UpdateStudentInfo(IUserData userData);
    }
}