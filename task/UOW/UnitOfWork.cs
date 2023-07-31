using task.Repositories;
using task.Models;
using System.Threading.Tasks;

namespace task.UOW
{
   
        public class UnitOfWork : IUnitOfWork,IDisposable
        {
            private readonly ApplicationDbContext _context;
            public IEmployeeRepository EmployeeRepository { get; private set; }

            public UnitOfWork(ApplicationDbContext context)
            {
                _context = context;
                EmployeeRepository = new EmployeeRepository(_context);
            }

            public void Save()
            {
                _context.SaveChanges();
            }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
