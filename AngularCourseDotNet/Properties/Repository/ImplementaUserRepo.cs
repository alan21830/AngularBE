using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCourseDotNet.Controllers.Models;
using Microsoft.EntityFrameworkCore;


// implementazione delle query
namespace AngularCourseDotNet.Properties.Repository
{

   
    public class ImplementaUserRepo : UserInterface
    {
        private readonly Context _db;

        public ImplementaUserRepo(Context db)
        {
            _db = db;
        }

        public async Task<bool> EsisteUser(string username)
        {

            var userVerifica = await _db.User.AnyAsync(u => u.Username == username);
            if (userVerifica)
            {
                return true;
            }
            return false;
        }

        public async Task<User> Login(string username, string password)
        {


            var user = await _db.User.FirstOrDefaultAsync(a => a.Username == username);
            if (user == null)
            { return null; }

            if (!VerificaPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            return user;
        }

        private bool VerificaPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computeHash.Length; i++)
                {
                    if (computeHash[i] != passwordHash[i])
                        return false ;
                }
                return true ;
            }
        }

        public async Task<User> Registra(User user, string password)
        {
            byte[] passwordHash, passwordSalt;

           CreaPasswordHash(password, out  passwordHash,out  passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
           await _db.User.AddAsync(user);
            await _db.SaveChangesAsync();




                return user;
        }

        private void CreaPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordHash = hmac.Key;
                passwordSalt = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
