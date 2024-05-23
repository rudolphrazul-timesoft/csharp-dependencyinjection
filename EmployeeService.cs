using csharp_dependencyinjection.Model;
using csharp_dependencyinjection.Repository;

namespace csharp_dependencyinjection
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly ILeaveRepository _leaveRepository;

        public EmployeeService(IEmployeeRepository employeeRepository, ILeaveRepository leaveRepository)
        {
            _employeeRepository = employeeRepository;
            _leaveRepository = leaveRepository;
        }

        public async Task<Employee> GetDataByEmployeeId(int employeeId)
        {
            var employee = new Employee();
            employee = await _employeeRepository.GetById(employeeId);
            employee.Leaves = await _leaveRepository.GetLeaveDataByEmployeeId(employeeId);

            return employee;
        }

    }
}
