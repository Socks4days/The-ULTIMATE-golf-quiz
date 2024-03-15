using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    // This class inherits from the User class and is intended to allow any admin-specific attributes to be stored
    internal class Admin : User
    {
        public Admin() { }

        public Admin(string username, string password, string name, int age, string gender, string nationality) : 
            base(username, password, name, age, gender, nationality)
        {

        }
    }
}
