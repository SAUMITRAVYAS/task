using task.Repositories;


namespace task.UOW
{

        public interface IUnitOfWork: IDisposable
        {
            IEmployeeRepository EmployeeRepository { get; }
            void Save();
        }
    
}
