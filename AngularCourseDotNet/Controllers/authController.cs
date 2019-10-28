using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCourseDotNet.Controllers.Models;
using AngularCourseDotNet.Properties.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCourseDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class authController : ControllerBase
    {
        private readonly Context _db;

        public authController(Context db)
        {
            _db = db;
        }

        //api/auth
        [HttpPost]
        public User login([FromBody] DtoLogin dto)
        {

            var x = _db.User.Where(u => u.Username == dto.username && u.password == dto.password).FirstOrDefault();
            if (x != null)

                return x; 
            return null;
        }



    }
}