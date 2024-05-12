using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОЕКТ2.Models
{
    class AuthData
    {
        public static AuthData Instance { get; private set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

        static AuthData()
        {
            Instance = new AuthData();
        }
    }
}
