using AngularCourseDotNet.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Properties.Repository
{
    public  interface  UserDtoRepository
    {
        void Add<T>(T entity) where T: class; 
        void Delete<T>(T entity) where T : class;
        Task<User> GetUser(int id);
          List<User> getAll();
        void addUser(User u);

        Task<bool> SaveAll();


    }
}
