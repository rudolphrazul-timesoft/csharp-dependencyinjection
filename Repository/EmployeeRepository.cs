using csharp_dependencyinjection.Model;

namespace csharp_dependencyinjection.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<Employee> GetById(int id)
        {
            await Task.Delay(100); //simulating async delay
            return new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Title = "IT Manager"
            };
        }

    }
}
