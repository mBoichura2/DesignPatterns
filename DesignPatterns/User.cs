using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Абстрактний клас користувача
    public abstract class User
    {
        public string Name { get; set; }
        public abstract void Login();
    }
}
