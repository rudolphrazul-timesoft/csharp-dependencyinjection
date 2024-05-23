using csharp_dependencyinjection.Model;

namespace csharp_dependencyinjection.Repository
{
    public interface ILeaveRepository
    {
        Task<List<Leave>> GetLeaveDataByEmployeeId(int employeeId);
    }
}
