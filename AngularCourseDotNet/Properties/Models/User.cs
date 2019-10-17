﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCourseDotNet.Controllers.Models
{


   
    public class User
    {

        public int Id { get; set; }
        public String  Username { get; set; }

        public string password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }


    }
}
