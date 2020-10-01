using System;
using System.ComponentModel.DataAnnotations;

namespace Authoapp.API.Entities
{
    public class PermissionType : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }
    }
}
