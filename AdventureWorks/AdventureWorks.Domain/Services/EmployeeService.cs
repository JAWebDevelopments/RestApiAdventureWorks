using AdventureWorks.Domain.Models;
using AdventureWorks.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Domain.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeRepository.GetById(id);
        }

    }
}
