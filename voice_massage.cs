using System.IO;
using System.Media;//enabling to play.wav file
using System;

namespace part1_programming_poe
{
    public class voice_massage//class fo handling vioce message
    {

        public voice_massage()//constructore  (executes when an object of this class is created)
        {

            {

                //we are getting the full location 
                // Get the full directory path where the program is running
                string full_location = AppDomain.CurrentDomain.BaseDirectory;

                // replace the bin\debug\folder in full
                // Remove the "bin\Debug\" part from the path to get the root project directory
                // This is useful to avoid any issues with different file paths during develo\\pment
                string new_path = full_location.Replace("bin\\Debug\\", "");// always use two (\\){you dont put any space after the comma

                //try and catch 
                // Try to play the voice message
                try
                {
                    // Combine the root directory with the file name to get the full path of voice.wav
                    string full_path = Path.Combine(new_path, "voice.wav");
                    // Create an instance of SoundPlayer to play the .wav file
                    using (SoundPlayer play = new SoundPlayer(full_path))
                    {

                        //play the audio 
                        play.PlaySync();

                    }// end of using
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                } //end of catch


            }//end of con

        }//end of class
    }//end ofd namespace

}