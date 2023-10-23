using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    internal class User : Register
    {
        string username;        
        string name;
        int age;
        string gender;
        string nationality;
        string password;
        
        public User() 
        {

        }
        public User(string username, string password, string name, int age, string gender, string nationality)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.nationality = nationality;
        }
        
    }
}
