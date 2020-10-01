using System;
using System.Collections.Generic;
using Authoapp.API.Entities;
using Authoapp.API.Services;
using Microsoft.AspNetCore.Mvc;


namespace Authoapp.API.Controllers
{
    [Route("api/Permisions")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            _permissionService = permissionService ??
                throw new ArgumentNullException(nameof(permissionService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<Permission>> GetPermissions()
        {
            var permissions = _permissionService.GetAll();

            return Ok(permissions);
        }

        [HttpGet("{permissionId}", Name = "GetPermission")]
        public IActionResult GetPermissionTypeById(int permissionId)
        {
            var permission = _permissionService.GetById(permissionId);

            if (permission == null) return NotFound();

            return Ok(permission);
        }

        [HttpPost(Name = "CreatePermission")]
        public ActionResult<Permission> CreatePermissionType(Permission permission)
        {
            if (permission == null) return BadRequest();

           var result =  _permissionService.Create(permission);

            return Ok(result);
        }

        [HttpPut(Name = "UpdatePermission")]
        public ActionResult UpdatePermissionType(Permission permission)
        {
            var result = _permissionService.GetById(permission.Id);

            if (result.Id <= 0)
                return NotFound();

            result.FirstName = permission.FirstName;
            result.LastName = permission.LastName;
            result.DateFrom = permission.DateFrom;
            result.DateTo = permission.DateTo;

            var updateResult = _permissionService.Update(result);

            return Ok(updateResult);
        }
    }
}
