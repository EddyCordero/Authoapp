using System;
using Authoapp.API.Entities;
using Authoapp.API.Framework;
using Authoapp.API.Repositories;

namespace Authoapp.API.Services
{
    public class PermissionService : BaseService<Permission, IPermissionRepository>, IPermissionService
    {
        public PermissionService(IPermissionRepository mainRepository) : base(mainRepository)
        { }

        protected override TaskResult<Permission> ValidateOnCreate(Permission entity)
        {
            return new TaskResult<Permission>();
        }

        protected override TaskResult<Permission> ValidateOnDelete(Permission entity)
        {
            return new TaskResult<Permission>();
        }

        protected override TaskResult<Permission> ValidateOnUpdate(Permission entity)
        {
            return new TaskResult<Permission>();
        }

    }

    public interface IPermissionService : IBaseService<Permission, IPermissionRepository> { }
}
