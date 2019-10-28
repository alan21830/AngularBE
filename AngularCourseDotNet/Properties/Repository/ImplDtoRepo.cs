using AngularCourseDotNet.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Properties.Repository
{
   
    public class ImplDtoRepo : UserDtoRepository

      

     {
        private readonly Context _db;
        public ImplDtoRepo(Context db)
        {
            _db = db;
        }
       
        public void Add<T>(T entity) where T : class
        {
            _db.Add(entity);
            _db.SaveChanges();
        }
        public void Delete<T>(T entity) where T : class
        {
            _db.Remove(entity);
        }

        public Task<User> GetUser(int id)
        {

            var user = _db.User.Include(p => p.Photos).Where(i => i.Id == id).FirstOrDefaultAsync();
            return user;
        }
        public List<User> getAll()
        {
            return  _db.User.Include(p=>p.Photos).ToList();

        }

      

        public Task<bool> SaveAll()
        {
            throw new NotImplementedException();
        }

        public void addUser(User u)
        {
            _db.User.Add(u);
            _db.SaveChanges();

        }
    }
}
