using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_ULTIMATE_golf_quiz.File_Handling
{   
    internal static class SoundFileHandler
    {
        // Sound file paths
        public const string backgroundMusic = "Background Music.wav";
        public const string countdownTimerMusic = "Timer.wav";
        public const string correctAnswerSound = "Correct Answer.wav";
        public const string wrongAnswerSound = "Wrong-Answer.wav";
        public const string holeInOneSound = "Hole In One.wav";
        public const string golfBallSound = "Golf Ball.wav";
  
        // Sound player used throughout the application
        private static System.Media.SoundPlayer activePlayer = new System.Media.SoundPlayer();
        private static bool looping = false;
        
        // Method to start playing a new sound
        public static void PlaySound(string soundFile)
        {
            activePlayer.Stop();
            activePlayer.SoundLocation = soundFile;
            activePlayer.Load();
            activePlayer.Play();
            looping = false;
        }

        // Method to stop playing the current sound
        public static void StopSound()
        {
            activePlayer.Stop();
            looping = false;
        }

        // Method to play the background music in a loop
        // Uses looping bool to only start it if it isn't already playing
        public static void PlaySoundLooping(string soundFile)
        {
            if (!looping)
            {
                activePlayer.Stop();
                activePlayer.SoundLocation = soundFile;
                activePlayer.Load();
                activePlayer.PlayLooping();
                looping = true;
            }
        }           
    }
}
