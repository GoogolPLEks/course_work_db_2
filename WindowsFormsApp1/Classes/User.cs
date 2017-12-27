﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public Role Role { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
