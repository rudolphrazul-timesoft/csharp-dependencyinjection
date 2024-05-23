using Microsoft.Extensions.DependencyInjection;
using csharp_dependencyinjection;
using csharp_dependencyinjection.Repository;

public static class Program
{
    public static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmployeeRepository, EmployeeRepository>()
            .AddSingleton<ILeaveRepository, LeaveRepository>()
            .AddSingleton<EmployeeService>()
            .BuildServiceProvider();

        //get the employee service
        var employeeService = serviceProvider.GetService<EmployeeService>();

        //get employee info and leave balance data eg Name, Leave type and balance
        var employeeData =  employeeService.GetInfoWithLeaveDataByEmployeeId(1).Result;

        /*
         Objectives: code the following requirements:
         1. Display (by writing to console) the Employee service results i.e. Employee Name and its leave data (Type and Balance)
         e.g.
         Employee Name: John Doe
         Leave Type: Annual, Balance: 8.0
         Leave Type: Medical, Balance: 10.0

         2. Implement the Employee service
        */

        //your code here

        Console.ReadLine();
    }
}