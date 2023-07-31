using task.Models;
using task.Repositories;
using task.UOW;

namespace task.Business
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<EmployeeDetails> GetAllEmployees()
        {
            return _unitOfWork.EmployeeRepository.GetAll();
        }

        public EmployeeDetails GetEmployeeById(int id)
        {
            return _unitOfWork.EmployeeRepository.GetById(id);
        }

        public void AddEmployee(EmployeeDetails employee)
        {
            _unitOfWork.EmployeeRepository.Add(employee);
            _unitOfWork.Save();
        }

        public void UpdateEmployee(EmployeeDetails employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Save();
        }

        public void DeleteEmployee(int id)
        {
            _unitOfWork.EmployeeRepository.Delete(id);
            _unitOfWork.Save();
        }
    
    }
}
