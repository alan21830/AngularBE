using AngularCourseDotNet.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Properties.Repository
{
    interface UserInterface
    {
        Task<User> Registra(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> EsisteUser( string username);


    }
}
