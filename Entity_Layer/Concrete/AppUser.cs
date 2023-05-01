using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Gender { get; set; }
    }
}
