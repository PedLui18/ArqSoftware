﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Empleado_Usuario
{
    internal class enviarEmail
    {
        public string Email { get; set; }
        public enviarEmail(string email)
        {
            Email = email;
        }

        public string enviarEmail()
        {
            return Email;
        }
    }
}
