using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApi.Model
{
    public class ApplicationUser:IdentityUser
    {
        [Column(TypeName="varchar(150)")]
        public string FullName { get; set; }
    }
}
