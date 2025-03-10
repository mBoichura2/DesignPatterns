using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    // Звичайний користувач
    public class RegularUser : User
    {
        public override void Login() => Console.WriteLine($"User {Name} logged in.");
        public void ViewReports() => Console.WriteLine("Viewing reports...");
    }
}
