using task.Models;

namespace task.Repositories
{
   
        public class EmployeeRepository : IEmployeeRepository
        {
            private readonly ApplicationDbContext _context;

            public EmployeeRepository(ApplicationDbContext context)
            {
                _context = context;
            }

            public IEnumerable<EmployeeDetails> GetAll()
            {
                return _context.employee_details.ToList();
            }

            public EmployeeDetails GetById(int id)
            {
                return _context.employee_details.Find(id);
            }

            public void Add(EmployeeDetails employee)
            {
                _context.employee_details.Add(employee);
            }

            public void Update(EmployeeDetails employee)
            {
                _context.employee_details.Update(employee);
            }

            public void Delete(int id)
            {
                var employee = _context.employee_details.Find(id);
                if (employee != null)
                {
                    _context.employee_details.Remove(employee);
                }
            }

            public void Save()
            {
                _context.SaveChanges();
            }
        }
}
