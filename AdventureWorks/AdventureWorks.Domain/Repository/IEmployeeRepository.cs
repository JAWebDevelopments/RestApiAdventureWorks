using AdventureWorks.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Domain.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetById(int BusinessEntityID);
    }
}
