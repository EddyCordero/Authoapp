using System;
using System.Collections.Generic;
using Authoapp.API.Entities;
using Authoapp.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Authoapp.API.Controllers
{
    [Route("api/PermisionsType")]
    [ApiController]
    public class PermissionTypeController : ControllerBase
    {
        private readonly IPermissionTypeService _permissionTypeService;

        public PermissionTypeController(IPermissionTypeService permissionTypeService)
        {
            _permissionTypeService = permissionTypeService ??
                throw new ArgumentNullException(nameof(permissionTypeService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<PermissionType>> GetPermissionTypes()
        {
            var permissionTypes = _permissionTypeService.GetAll();

            return Ok(permissionTypes);
        }

        [HttpGet("{permissionId}", Name = "GetPermissionType")]
        public IActionResult GetPermissionTypeById(int permissionId)
        {
            var permissionType = _permissionTypeService.GetById(permissionId);

            if (permissionType == null) return NotFound();

            return Ok(permissionType);
        }

        [HttpPost(Name = "CreatePermissionType")]
        public ActionResult<PermissionType> CreatePermissionType(PermissionType permissionType)
        {
            if (permissionType == null) return BadRequest();

           var result =  _permissionTypeService.Create(permissionType);

            return Ok(result);
        }

        [HttpPut(Name = "UpdatePermissionType")]
        public ActionResult UpdatePermissionType(PermissionType permissionType)
        {
            var result = _permissionTypeService.GetById(permissionType.Id);
            if (result.Id <= 0)
                return NotFound();

            result.Description = permissionType.Description;
            result.Notes = permissionType.Notes;

            var updateResult = _permissionTypeService.Update(permissionType);

            return Ok(updateResult);
        }
    }
}
