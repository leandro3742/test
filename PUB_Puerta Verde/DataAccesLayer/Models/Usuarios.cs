using Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Models
{
    public class Usuarios: IdentityUser
    {
        public List<Roles> usuariosRoles { get; set; }
    }
}
