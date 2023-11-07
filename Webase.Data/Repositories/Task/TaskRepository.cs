using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class TaskRepository : GenericRepository<Task, int>, ITaskRepository
{
    public TaskRepository(PostgresContext appDbContext) 
        : base(appDbContext)
    {
    }
}
