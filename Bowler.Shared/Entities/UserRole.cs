﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowler.Shared.Entities
{
    public class UserRole
    {
        [Required(ErrorMessage = "El ID es obligatorio")]
        [MaxLength(20, ErrorMessage = "El ID debe tener máximo 20 caractéres.")]
        public int Id { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
