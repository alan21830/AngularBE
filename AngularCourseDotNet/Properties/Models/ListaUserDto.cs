using AngularCourseDotNet.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Properties.Models
{
    public class ListaUserDto
    {
        public int Id { get; set; }



        public String Username { get; set; }

        public string password { get; set; }
       
        public string gender { get; set; }

        public ICollection<Photo> Photo { get; set; }

    }
}
