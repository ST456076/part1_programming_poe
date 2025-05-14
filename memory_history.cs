using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace part1_programming_poe
{
   internal class memory_history
    {
        // Static list to hold all user inputs in memory


        // Constructor that receives a topic/question
        public static List<string> userSearchHistory = new List<string>();

        // File path for storing history
        private string filePath = "history_memory.txt";

        // Constructor that receives a topic/question
        public memory_history(string topic)
        {
            // Load previous search history from file
            LoadHistory();

            // Add new topic to memory
            userSearchHistory.Add(topic);

            // Append topic to file
            File.AppendAllText(filePath, topic + Environment.NewLine);

            // Display memory history
            Console.WriteLine("\nUser Search History:");
            foreach (string item in userSearchHistory)
            {
                Console.WriteLine("- " + item);
            }
        }

        // Method to load previous search history
        private void LoadHistory()
        {
            if (File.Exists(filePath))
            {
                userSearchHistory = File.ReadAllLines(filePath).ToList();
            }
        }
    }
}


