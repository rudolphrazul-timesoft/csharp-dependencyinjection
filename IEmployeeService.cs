using csharp_dependencyinjection.Model;

namespace csharp_dependencyinjection
{
    public interface IEmployeeService
    {
        Task<Employee> GetInfoWithLeaveDataByEmployeeId(int employeeId);
    }
}
