using System;
using System.Collections;
using System.Collections.Generic;

namespace part1_programming_poe
{
    public class filter_questions
    {
        private List<string> answers = new List<string>();
        private List<string> ignore = new List<string>();
        private Dictionary<string, List<string>> keyword_answers = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> extraTips;
        private Random random = new Random();
        private string userName;

        public delegate string user_name();

        public filter_questions()
        {
            random_response tips = new random_response("tips");
            extraTips = tips.Tips;

            store_keywords();
            store_answers();
            store_ignore();

            user_name getUserName = () =>
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("AIBot>> I'm X.O the bot. Before we start, please enter your name:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("user>: ");
                return Console.ReadLine();
            };

            userName = getUserName();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{userName}, that's such a nice name! Welcome! I will be your bot!");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-------------------------------------------------------------------------------------");

            string interaction = "how can I help you today? type 'exit' to quit";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"AIBot>> {interaction}");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write(userName + " >: ");
                string question = Console.ReadLine();

                if (question.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AIBot>> Goodbye! Stay safe from cyber attacks!");
                    break;
                }

                ProcessQuestion(question);
                interaction = "Is there anything else you'd like to know about cybersecurity? (type 'exit' to quit)";
            }
        }

        private void ProcessQuestion(string question)
        {
            // Sentiment analysis first
            string sentiment = DetectSentiment(question);
            if (sentiment == "negative")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("AIBot>> " + GetEncouragingMessage());
            }
            else if (sentiment == "positive")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("AIBot>> I'm glad to hear you're feeling positive about this, " + userName + "!");
            }

            string[] words = question.ToLower().Split(' ');
            ArrayList filteredWords = new ArrayList();

            foreach (string word in words)
            {
                string cleaned = word.Trim(new char[] { '?', '.', ',' });
                if (!ignore.Contains(cleaned))
                {
                    filteredWords.Add(cleaned);
                }
            }

            // Handle tips
            foreach (string word in filteredWords)
            {
                if (question.ToLower().Contains("tip") && extraTips.ContainsKey(word))
                {
                    List<string> tipsList = extraTips[word];
                    if (tipsList.Count > 0)
                    {
                        int index = random.Next(tipsList.Count);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"AIBot>> Here's a tip on {word}:");
                        Console.WriteLine($"AIBot>> {tipsList[index]}");
                        return;
                    }
                }
            }

            // Keyword-based response
            foreach (string word in filteredWords)
            {
                if (keyword_answers.ContainsKey(word))
                {
                    List<string> responses = keyword_answers[word];
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AIBot>> " + responses[0]);
                    AskFollowUp(word);
                    return;
                }
            }

            // Fallback to best match
            string bestResponse = null;
            int bestMatchCount = 0;

            foreach (string answer in answers)
            {
                int matchCount = 0;
                foreach (string word in filteredWords)
                {
                    if (answer.ToLower().Contains(word))
                    {
                        matchCount++;
                    }
                }

                if (matchCount > bestMatchCount)
                {
                    bestMatchCount = matchCount;
                    bestResponse = answer;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (!string.IsNullOrEmpty(bestResponse))
            {
                Console.WriteLine("AIBot>> " + bestResponse);
            }
            else
            {
                Console.WriteLine("AIBot>> Sorry, I can only assist with cybersecurity-related questions.");
            }
        }

        private void AskFollowUp(string keyword)
        {
            Dictionary<string, string> followUps = new Dictionary<string, string>
            {
                { "password", "Would you like to know anything more about passwords?" },
                { "phishing", "Do you want to learn how to spot phishing scams?" },
                { "browser", "Would you like to know more about safe browsing habits?" }
            };

            if (followUps.ContainsKey(keyword))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"AIBot>> {followUps[keyword]} (Type 'yes' or 'no')");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{userName} >: ");
                string response = Console.ReadLine()?.ToLower();

                if (response == "yes")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AIBot>> Great! Here's more information...");
                    foreach (string answer in answers)
                    {
                        if (answer.ToLower().Contains(keyword))
                        {
                            Console.WriteLine("AIBot>> " + answer);
                            return;
                        }
                    }
                    Console.WriteLine("AIBot>> Sorry, I don't have additional information on that.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("AIBot>> No worries! Let me know what else I can assist with.");
                }
            }
        }

        private void store_keywords()
        {
            keyword_answers.Add("cybersecurity", new List<string> {
                "Cybersecurity is the practice of protecting computers, networks, and data from hackers, viruses, and other cyber threats."
            });
            keyword_answers.Add("phishing", new List<string> {
                "Phishing is a type of social engineering attack where attackers use fake emails, texts, or websites to steal sensitive information."
            });
            keyword_answers.Add("password", new List<string> {
                "A password is a secret sequence of characters used to access secure systems or data. It's like a digital key only you should know."
            });
            keyword_answers.Add("browser", new List<string> {
                "A safe browser protects users from harmful websites and other online threats."
            });
            keyword_answers.Add("threats", new List<string> {
                "Common threats include malware, ransomware, phishing, and viruses."
            });
            keyword_answers.Add("hi", new List<string> {
                "Hi there! How can I help you today?"
            });
        }

        private void store_answers()
        {
            answers.Add("My purpose is to teach you more about cybersecurity and the risks that come with the lack of knowledge about cyber attacks and threats.");
            answers.Add("You can ask about anything related to cybersecurity awareness.");
            answers.Add("Common threats include spyware, adware, Trojans, worms, rootkits, keyloggers, and botnets.");
            answers.Add("Phishing is a cyber attack where fake emails or websites trick people into revealing sensitive data.");
            answers.Add("Creating strong passwords helps keep accounts secure.");
            answers.Add("I'm good! How can I assist you today?");
            answers.Add("To protect yourself from phishing attacks, report suspicious emails and stay informed.");
            answers.Add("A safe browser protects users from harmful websites and cyber threats.");
        }

        private void store_ignore()
        {
            ignore.Add("what");
            ignore.Add("tell");
            ignore.Add("about");
            ignore.Add("are");
            ignore.Add("me");
            ignore.Add("more");
            ignore.Add("do");
            ignore.Add("is");
            ignore.Add("the");
            ignore.Add("it");
            ignore.Add("i");
            ignore.Add("we");
            ignore.Add("please");
        }

        private string DetectSentiment(string input)
        {
            input = input.ToLower();
            string[] negativeWords = { "scared", "worried", "afraid", "confused", "panic", "anxious", "frustrated", "angry", "sad", "lost" };
            string[] positiveWords = { "great", "good", "happy", "relieved", "confident", "excited" };

            foreach (string word in negativeWords)
            {
                if (input.Contains(word))
                {
                    return "negative";
                }
            }

            foreach (string word in positiveWords)
            {
                if (input.Contains(word))
                {
                    return "positive";
                }
            }

            return "neutral";
        }

        private string GetEncouragingMessage()
        {
            List<string> messages = new List<string>
            {
                "You're doing great by asking questions. Knowledge is power!",
                "It's okay to feel unsure — that's why I'm here.",
                "Asking for help is a sign of strength. You're not alone.",
                "Cybersecurity can seem overwhelming, but step by step, you'll understand it better."
            };
            return messages[random.Next(messages.Count)];
        }
    }
}
