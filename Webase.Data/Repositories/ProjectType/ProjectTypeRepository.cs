using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class ProjectTypeRepository : GenericRepository<ProjectType, int>, IProjectTypeRepository
{
    public ProjectTypeRepository(PostgresContext appDbContext) : base(appDbContext)
    {
    }
}
