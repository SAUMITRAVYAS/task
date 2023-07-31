using task.Models;

namespace task.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeDetails> GetAll();
        EmployeeDetails GetById(int id);
        void Add(EmployeeDetails employee);
        void Update(EmployeeDetails employee);
        void Delete(int id);
        void Save();
    }
}
