using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz
{
    // Base class for all users
    public class User
    {
       // properties of the user class are created
        public string username { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public string password { get; set; }
        
        // Default constructor
        public User() 
        {
        }
        
        // creates the user objects with the relevant information
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
