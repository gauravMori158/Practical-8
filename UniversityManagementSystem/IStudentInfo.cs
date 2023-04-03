namespace UniversityManagementSystem
{
    internal interface IStudentInfo
    {
        void ViewDetail(IUserData userData);
        void ViewDetail(IUserData userData, int id);
    }
}