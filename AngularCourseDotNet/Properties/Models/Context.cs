using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Controllers.Models
{


    public class Context : DbContext
    { 

   
        public Context(DbContextOptions<Context> options) : base(options) { }
   

    public DbSet<Value> Values { get; set; }
        public DbSet<User> User { get; set; }
    }
}
