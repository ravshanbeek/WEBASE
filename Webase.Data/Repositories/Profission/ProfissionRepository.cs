namespace Webase.Data.Repositories;

public class ProfissionRepository : GenericRepository<Profission,int>, IProfissionRepository
{
    public ProfissionRepository(PostgresContext appDbContext) 
        : base(appDbContext)
    {
    }
}