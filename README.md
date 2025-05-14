# 💬 Cybersecurity Awareness Bot – Console Application

This is a simple console-based chatbot designed to raise cybersecurity awareness. It interacts with users through text, plays a voice message, displays an ASCII logo, and answers cybersecurity-related questions with personalized responses.

## 📁 Project Details
**Project Name:** part1_programming_poe  
**Framework:** .NET Framework 4.7.2  
**Template:** Console App (.NET Framework)  

## 🚀 Main Class
**What it contains:**  
- Creates instances of classes: voice message, logo image, and filter questions.

**How it works:**  
1. Starts with a voice message and a logo display.  
2. Prompts the user for their name to personalize the chat.  
3. Displays colored responses to distinguish between user and bot.  
4. Enters a chat loop where the user can ask cybersecurity questions.  

## 🔊 Voice Message Class
**Purpose:**  
- Plays a voice greeting when the chatbot starts.  

**How it works:**  
1. Locates the audio file from the main project directory.  
2. Plays the audio message.  
3. Uses error handling in case the audio fails.  

## 🖼️ Logo Image Class
**Purpose:**  
- Displays an ASCII version of a logo after the voice message.  

**How it works:**  
1. Loads an image and converts it into text using grayscale shading.  
2. Displays the image resized to fit the console window.  

## ❓ Filter Questions Class
**Purpose:**  
- Allows the user to ask questions about cybersecurity and gives accurate answers.  

**How it works:**  
1. Keeps asking questions until the user types `"exit"`.  
2. Filters out unnecessary words from the input.  
3. Compares input keywords with predefined answers.  
4. Replies with the most relevant answer or a fallback message.  

## 🧠 Random Response Class
**Purpose:**  
- Provides random cybersecurity tips based on different topics like phishing or general safety.  

**How it works:**  
1. Stores tips in a list for each topic.  
2. Can be expanded with more topics and tips.  
3. Helps the chatbot give additional advice to users.  

## 🧾 Ignored Words
To focus on important keywords, the bot ignores words like:  
**your, can, how, what, tell, about, are, me, more**  

## 💬 Predefined Responses
The chatbot can answer questions such as:  
- **What is cybersecurity?**  
- **What are common online threats?**  
- **How can I protect my password?**  
- **What is phishing?**  
- **How do I stay safe online?**  

It also responds politely with friendly greetings and helpful reminders.  

## 🧠 (Optional) History Memory Class
**Purpose:**  
- Stores the user's questions and the chatbot’s responses.  
- Can save the conversation to a file.  
- Helps track frequently asked questions or improve the bot later.  

## ✅ Features Summary
- Voice welcome message  
- ASCII logo image display  
- Personalized chat using the user’s name  
- Friendly, color-coded console messages  
- Smart filtering of user input  
- Predefined and accurate cybersecurity answers  
- Random tips for topics like phishing  
- Continuous chat loop until the user exits  
- Optional memory feature to store chat history  

## 📦 How to Run
1. Clone the repository from GitHub.  
2. Open the solution in Visual Studio.  
3. Make sure the project targets **.NET Framework 4.7.2**.  
4. Press
