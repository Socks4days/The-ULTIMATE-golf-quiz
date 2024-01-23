using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class Admin : User
    {
        public Admin() { }

        public Admin(string username, string password, string name, int age, string gender, string nationality) : base(username, password, name, age, gender, nationality)
        {

        }
    }
}
