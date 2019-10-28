using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCourseDotNet.Controllers.Models;
using AngularCourseDotNet.Properties.Models;
using AngularCourseDotNet.Properties.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularCourseDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserDtoRepository _repo;

        public UserController(UserDtoRepository repo)
        {
            _repo = repo;
        }


        [HttpPost]
        public User addUser([FromBody] User user)
        {

            _repo.addUser(user);
            return user;
        }



        [HttpGet]
        public List<ListaUserDto> get()
        {
            var user= _repo.getAll();
            List<ListaUserDto> list = new List<ListaUserDto>();

            for (int i = 0; i < user.Count; i++ ) {

                ListaUserDto l = new ListaUserDto()
                {
                    Id = user[i].Id,
                    gender = user[i].gender,
                    password = user[i].password,
                    Username = user[i].Username,
                    
                

                };
                list.Add(l);
            }
            return list;



        }

    }
}