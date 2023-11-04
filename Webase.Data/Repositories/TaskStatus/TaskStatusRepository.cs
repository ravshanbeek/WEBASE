using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class TaskStatusRepository : GenericRepository<TaskStatus, int>, ITaskStatusRepository
{
    public TaskStatusRepository(PostgresContext appDbContext) : base(appDbContext)
    {
    }
}
