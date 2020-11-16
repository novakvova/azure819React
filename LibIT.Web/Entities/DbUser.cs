﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace LibIT.Web.Entities
{
    public class DbUser : IdentityUser<long>
    {
        [StringLength(255)]
        public string Image { get; set; }

        [Range(0, 130, ErrorMessage = "Недопустимый год")]
        public int Age { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public virtual ICollection<DbUserRole> UserRoles { get; set; }
    }
}