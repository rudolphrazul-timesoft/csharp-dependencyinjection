using csharp_dependencyinjection.Model;

namespace csharp_dependencyinjection.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetById(int id);
    }
}
