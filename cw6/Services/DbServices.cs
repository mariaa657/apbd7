namespace cw6.Services;

public interface IDbService
{
    Task<Student?> GetStudentDetailsById(int id);
    Task<Group?> GetGroupById(int id);
    Task<Student> AddStudentWithGroupsAssignments(Student student);
}


public class DbServices
{
    
}