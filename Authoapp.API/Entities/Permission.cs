using System;
using System.ComponentModel.DataAnnotations;

namespace Authoapp.API.Entities
{
    public class Permission : BaseEntity
    { 
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateFrom { get; set; }

        [Required]
        public DateTimeOffset DateTo { get; set; }

        [Required]
        public int PermissionTypeId { get; set; }

        public PermissionType PermissionType { get; set; }
    }
}
