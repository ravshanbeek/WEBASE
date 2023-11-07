using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class PriorityStatusRepository : GenericRepository<PriorityStatus, int>, IPriorityStatusRepository
{
    public PriorityStatusRepository(PostgresContext appDbContext) : base(appDbContext)
    {
    }
}
