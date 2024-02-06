using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_ULTIMATE_golf_quiz
{
    public class AvatarFileHandler
    {
        const string avatarFilePath = "Avatar Paths.csv";

        public static List<string> avatars = frmAvatarChange.avatars;
        public AvatarFileHandler()
        {

        }        
        public static void ReadInAvatars()
        {
            string line;
            string[] avatarInfo = new string[2];
            
            using (StreamReader sr = new StreamReader(avatarFilePath))
            {                
                // Read details of each player until the end of the file
                while(!sr.EndOfStream)
                {
                   line = sr.ReadLine();
                  // puts all of the information into the already created array
                   avatarInfo = line.Split(',').ToArray();
                  
                    if (line == SplashScreen.player.username)
                       avatars.Add(avatarInfo[1]);
                }
                sr.Close();
            }
            avatars.ToArray();

        }
       
        // method that will write out to the csv file to save all the users
        public static void SaveAllAvatars()
        {
           
            using (StreamWriter sw = new StreamWriter(avatarFilePath))
            {        
                foreach (string avatar in avatars)
                {
                   // sw.WriteLine("{0},{1}",
                    //player.username, player.password);
                }
                sw.Close();
            }
        }

       

    }
}