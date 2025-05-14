using System.Collections.Generic;
using System;
using System.Security.Permissions;

namespace part1_programming_poe
{
    public class random_response
    {
        //adding 
        public Dictionary<string, List<string>> Tips { get; private set; }
        public random_response(string topic)

        {
            Tips = new  Dictionary<string, List<string>>();
            // Storing responses for different topics
         Tips["cybersecurity"]= new List<string>()
            {
                "Use a mix of uppercase, lowercase, numbers, and symbols in passwords.",
                "Enable two-factor authentication for extra protection.",
                "Beware of phishing scams—never click suspicious links.",
                "Use a password manager to store credentials securely."
            };
            Tips = new Dictionary<string, List<string>>
{
         { "phishing", new List<string>
        {
            "Be cautious of emails that ask for personal information.",
            "Check the sender's email address carefully before clicking any links.",
            "Don't click links in unsolicited messages — hover to preview the URL first.",
            "Use multi-factor authentication to add extra protection against phishing attacks."
        }
    }
};


            Tips["security"] = new List<string>()
            {
                "Always validate user input to prevent security vulnerabilities.",
                "Use meaningful variable names to improve code readability.",
                "Follow the DRY principle: Don't Repeat Yourself.",
                "Break large functions into smaller, modular components."
            };

            Tips["generallife"] = new List<string>()
            {
                "Stay curious—learning never stops.",
                "Always back up your important files.",
                "Practice mindfulness for mental well-being.",
                "Time management is key to productivity."
            };
            Tips["password"] = new List<string>
            {
                "Use a mix of uppercase, lowercase, numbers, and special characters.",
                "Avoid common passwords like '123456' or 'password'.",
                "Use a unique password for every account.",
                "Consider using a password manager to store secure passwords."
            };
            Tips["browser"] = new List<string>
{
    "Always check the URL for 'https://' before entering sensitive information.",
    "Avoid clicking on suspicious pop-ups or ads.",
    "Keep your web browser updated to patch security vulnerabilities.",
    "Use a secure and reputable web browser with built-in protection features.",
    "Install ad blockers or anti-tracking extensions to increase privacy.",
    "Don’t download software or files from untrusted websites.",
    "Regularly clear your browsing data and cache to avoid data leakage.",
    "Be cautious when using public Wi-Fi — use a VPN if possible."
};


        }
    }
}