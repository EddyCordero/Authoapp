using Authoapp.API.Entities;
using Authoapp.API.DbContexts;

namespace Authoapp.API.Repositories
{
    public class PermissionTypeRepository : BaseRepository<PermissionType>, IPermissionTypeRepository
    {
        public PermissionTypeRepository(AuthoappDbContext database) : base(database)
        { }
    }

    public interface IPermissionTypeRepository : IBaseRepository<PermissionType> { }
}
