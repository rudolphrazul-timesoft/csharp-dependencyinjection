using Microsoft.Extensions.DependencyInjection;
using csharp_dependencyinjection;
using csharp_dependencyinjection.Repository;
using csharp_dependencyinjection.Model;

public static class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmployeeRepository, EmployeeRepository>()
            .AddSingleton<ILeaveRepository, LeaveRepository>()
            .AddSingleton<EmployeeService>()
            .BuildServiceProvider();

        var employeeService = serviceProvider.GetService<EmployeeService>();
        var employeeData =  employeeService.GetDataByEmployeeId(1).Result;

        Console.WriteLine("Employee Name: {0} {1}", employeeData.FirstName, employeeData.LastName);
        foreach (var leave in employeeData.Leaves)
            Console.WriteLine("Leave: {0} {1}", leave.Type, leave.Balance);

        Console.ReadLine();
    }
}