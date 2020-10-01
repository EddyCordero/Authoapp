using Authoapp.API.Entities;
using Authoapp.API.Framework;
using Authoapp.API.Repositories;

namespace Authoapp.API.Services
{
    public class PermissionTypeService : BaseService<PermissionType, IPermissionTypeRepository>, IPermissionTypeService
    {
        public PermissionTypeService(IPermissionTypeRepository mainRepository) : base(mainRepository)
        { }

        protected override TaskResult<PermissionType> ValidateOnCreate(PermissionType entity)
        {
            return new TaskResult<PermissionType>();
        }

        protected override TaskResult<PermissionType> ValidateOnDelete(PermissionType entity)
        {
            return new TaskResult<PermissionType>();
        }

        protected override TaskResult<PermissionType> ValidateOnUpdate(PermissionType entity)
        {
            return new TaskResult<PermissionType>();
        }
    }

    public interface IPermissionTypeService : IBaseService<PermissionType, IPermissionTypeRepository> { }
}
