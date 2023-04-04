namespace UniversityManagementSystem
{
    internal interface IUserData
    {
        Dictionary<int, StudentClass> UserDictionary { get; set; }
    }
}