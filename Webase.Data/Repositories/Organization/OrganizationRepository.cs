using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webase.Data.Repositories;

public class OrganizationRepository : GenericRepository<Organization, int>, IOrganizationRepository
{
    public OrganizationRepository(PostgresContext appDbContext) 
        : base(appDbContext)
    {
    }
}
