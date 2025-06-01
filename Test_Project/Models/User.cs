using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project.Models
{

    public class User
    {
        public int Id { get; set; } 
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // В реальном приложении хранить хэш!
        public string Name { get; set; } = string.Empty;
    }
}
