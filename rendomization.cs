using System.Collections.Generic;
using System;

namespace part1_programming_poe
{
    internal class rendomization
    {

        public rendomization(string userInput)
        {
            userInput = userInput.ToLower(); // Ensure consistency in keyword matching

            // Define predefined responses
            List<string> phishingTips = new List<string>()
            {
                "Don't click on suspicious links.",
                "Always check the sender's email address.",
                "Use multi-factor authentication when possible."
            };

            List<string> passwordTips = new List<string>()
            {
                "Use at least 12 characters.",
                "Include letters, numbers, and symbols.",
                "Avoid using the same password everywhere."
            };

            List<string> scamTips = new List<string>()
            {
                "Don't trust deals that sound too good to be true.",
                "Never send money to people you don't know.",
                "Check the source before clicking any links."
            };

            // Determine response category based on user input
            List<string> selectedTips = null;
            string category = "";

            if (userInput.Contains("phishing"))
            {
                selectedTips = phishingTips;
                category = "Phishing";
            }
            else if (userInput.Contains("password tips"))
            {
                selectedTips = passwordTips;
                category = "Password Security";
            }
            else if (userInput.Contains("scam"))
            {
                selectedTips = scamTips;
                category = "Scam Prevention";
            }

            if (selectedTips != null)
            {
                Random randomGenerator = new Random();
                int randomIndex = randomGenerator.Next(0, selectedTips.Count);

                Console.WriteLine($"{category} Tip: {selectedTips[randomIndex]}");
            }
            else
            {
                Console.WriteLine("Sorry, I don't have tips for that topic yet.");
            }
        }
    }
    }