using AdventureWorks.Domain.Models;
using AdventureWorks.Domain.Repository;
using Microsoft.EntityFrameworkCore;


namespace AdventureWorks.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AdventureWorks2019Context _context;

        public EmployeeRepository(AdventureWorks2019Context context)
        {
            _context = context;
        }

        public Employee GetById(int BusinessEntityID)
        {
            return _context.Employees.SingleOrDefault(e => e.BusinessEntityId == BusinessEntityID);
        }
    }
}
