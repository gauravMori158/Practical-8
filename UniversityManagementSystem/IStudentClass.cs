namespace UniversityManagementSystem
{
    internal interface IStudentClass
    {
        string Email { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        long PhoneNo { get; set; }
    }
}