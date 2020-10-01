using Authoapp.API.DbContexts;
using Authoapp.API.Entities;

namespace Authoapp.API.Repositories
{

    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(AuthoappDbContext database) : base(database)
        { }
    }

    public interface IPermissionRepository : IBaseRepository<Permission> { }
}
