using csharp_dependencyinjection.Model;

namespace csharp_dependencyinjection.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly List<Leave> _employeeLeaves;
        public LeaveRepository()
        {
            _employeeLeaves = new List<Leave>();

            _employeeLeaves.Add(new Leave { Id = 1, EmployeeId = 1, Type = "Annual", Balance = 8.5 });
            _employeeLeaves.Add(new Leave { Id = 2, EmployeeId = 1, Type = "Medical", Balance = 12 });
            _employeeLeaves.Add(new Leave { Id = 3, EmployeeId = 1, Type = "Child Care", Balance = 1.5 });

            _employeeLeaves.Add(new Leave { Id = 4, EmployeeId = 2, Type = "Annual", Balance = 5 });
            _employeeLeaves.Add(new Leave { Id = 5, EmployeeId = 2, Type = "Medical", Balance = 8 });
            _employeeLeaves.Add(new Leave { Id = 6, EmployeeId = 2, Type = "Child Care", Balance = 0 });

        }
        public async Task<List<Leave>> GetLeaveDataByEmployeeId(int employeeId)
        {
            await Task.Delay(100); //simulating async delay

            return _employeeLeaves
                .Where(e => e.EmployeeId == employeeId).ToList();
        }
    }
}
