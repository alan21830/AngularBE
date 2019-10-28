using AngularCourseDotNet.Controllers.Models;
using AutoMapper;
 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Properties.Models
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<User, ListaUserDto>();



        }

    }
}
