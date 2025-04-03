using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace part1_programming_poe
{
    public class filter_questions
    {
        // Declaring variables using ArrayList
        ArrayList answers = new ArrayList();
        ArrayList ignore = new ArrayList();

        // Constructor
        public filter_questions()
        {
            // Initialize methods
            store_answers();
            store_ignore();

            // Prompt user for their name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("AIBot>> Before we start, please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("user>: ");
            string userName = Console.ReadLine();

            // Welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(userName + " " + " welcome! I will be your bot!");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------------------------------------");

            // Continuously interact with the user
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bot>> How may I assist you today? (Type 'exit' to quit)");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(userName + " >: ");
                string question = Console.ReadLine();

                // Exit condition i the user has nothing to input
                if (question.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AIBot>> Goodbye! Stay safe from cyber attecks !");
                    break;
                }

                // Process the question
                ProcessQuestion(question);
            }
        }

        private void ProcessQuestion(string question)
        {
            // Split and filter user input
            string[] store_word = question.ToLower().Split(' ');
            ArrayList store_final_word = new ArrayList();

            foreach (string word in store_word)
            {
                // Remove character like '?'
                //this will help me i ask a qustion and uses  a quesstion mark 
                string charecters = word.Trim(new char[] { '?' });
                if (!ignore.Contains(charecters))
                {
                    store_final_word.Add(charecters);
                }
            }

            // Find the best matching answer
            string resp = null;
            int firstMatches = 0;

            foreach (string answer in answers)
            {
                int matchCount = 0;
                foreach (string word in store_final_word)
                {
                    if (answer.ToLower().Contains(word))
                    {
                        matchCount++;
                    }
                }

                if (matchCount > firstMatches)
                {
                    firstMatches = matchCount;
                    resp = answer;
                }
            }

            // Display the best answer or default response
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (!string.IsNullOrEmpty(resp))
            {
                Console.WriteLine("AIBot>> " + resp);
            }
            else
            {
                Console.WriteLine("AIBot>> Sorry, I can only assist with cybersecurity-related questions.");
            }
        }

        // Method to store predefined answers
        private void store_answers()
        {
            answers.Add("My purpose is to teach you more about cybersecurity and the risks that come with the lack of knowledge about cyber attacks and threats.");
            answers.Add("You can ask about anything related to cybersecurity awareness.");
            answers.Add("Common Threats areas follow Viruses, malware and ransomware are some dangers in cyberspace.");
            answers.Add("Phishing is a type of social engineering attack where attackers use fraudulent emails, text messages, or websites to trick individuals into revealing sensitive information like credit card details, often by impersonating legitimate organizations or individuals");
            answers.Add("Password can be protected by using strong and unique passwords. Avoid using your birthday, cellphone number, or anything that a hacker can easily guess.");
            answers.Add("I'm good! How are you, and how can I assist you today?");
            answers.Add("Cybersecurity is the practice of protecting computers, networks, and data from hackers, viruses, and other cyber threats. It helps keep personal and business information privte from being stolen, damaged, or misused. Think of it like locking your doors and windows to keep burglars out, but for digital devices and online activities.");
            answers.Add("To protect yourself from phishing attacks, immediately report suspicious emails and stay informed about the latest phishing scams.");
            answers.Add("Hi how are you! how can i assist you today?");
            answers.Add("Safe browser refers to a web browser designed with enhanced security features to protect users from potentially harmful websites, malware, and other online threat");

        }


        // Method to store ignored words
        private void store_ignore()
        {

            ignore.Add("your");
            ignore.Add("can");
            ignore.Add("how");
            ignore.Add("what");
            ignore.Add("tell");
            ignore.Add("about");
            ignore.Add("are");
            ignore.Add("me");
            ignore.Add("more");

        }
    }
}
