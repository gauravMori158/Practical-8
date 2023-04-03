namespace UniversityManagementSystem
{
    internal interface IUserData
    {
        Dictionary<int, StudentClass> GetDictionary { get; set; }
    }
}