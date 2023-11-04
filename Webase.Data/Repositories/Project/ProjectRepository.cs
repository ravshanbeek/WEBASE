using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class ProjectRepository : GenericRepository<Project, int>, IProjectRepository
{
    public ProjectRepository(PostgresContext appDbContext) 
        : base(appDbContext)
    {
    }
}
