using task.Models;
using System.Collections.Generic;
namespace task.Business

{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDetails> GetAllEmployees();
        EmployeeDetails GetEmployeeById(int id);
        void AddEmployee(EmployeeDetails employee);
        void UpdateEmployee(EmployeeDetails employee);
        void DeleteEmployee(int id);
    }
}
