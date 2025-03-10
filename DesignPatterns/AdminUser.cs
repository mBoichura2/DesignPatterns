using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // Адміністратор
    public class AdminUser : User
    {
        public override void Login() => Console.WriteLine($"Admin {Name} logged in.");
        public void ManageUsers() => Console.WriteLine("Managing users...");
    }
}
