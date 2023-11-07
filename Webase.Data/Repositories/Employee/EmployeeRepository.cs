using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class EmployeeRepository : GenericRepository<Employee, int>, IEmployeeRepository
{
    public EmployeeRepository(PostgresContext appDbContext) 
        : base(appDbContext)
    {
    }
}
