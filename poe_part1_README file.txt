# poe part 1 README file

- this is a simple cybersecurity awareness bot that uses console interactive appplication to communicate with the user.

# project details
- project name: part1_programming_poe
- natefame:4.7.2
- templete: console App (.Net framework)

# Main class 

### what does it contain?
- instance classes
--
### how does it work?
- the main pclas initialize the instance of a voice_message, logo_image and filter_questions class.
- it desplay a welcome message and prompt  the user for their name for personalization purposes.
- design of a  welcome message and a change of color between a user and a bot 

# voice_message class
- this class is responseble for playing the voice message  for the user 

### what does it contain
- constructor
- directory location 
- try and catch 
- console appication

### how does it work 
- use a constructore to execute when the object of a class is created.
- this project get the full directory path using the Appdomain and the current domain. 
- Remove the "bin\Debug\" part from the path to get the root project directory to avoid any issues with different file paths during development
- try to play the voice message by Combining the root directory with the file name to get the full path of voice.wav
- it will catch the error exception if the audio has a problem 


# logo_image class
- this class desplay the logo image in ASCII art aftre voice massege 

 ### what does it contains 
- derectore path
- for loop
- console application
 
### how does it work?
- get the full directory path using the Appdomain and the current domain. 
- Remove the "bin\Debug\" part from the path to get the root project directory to avoid any issues with different file paths during development
- combine the root directory path with the image file name to get the full path of the image
- for this class to be able to crate a ASCII image they must be use of Bitmap in a class
- the image is then being resizes to fit the window of a console 
- in this class the for loop is use to Get the color of the current pixel at (width, height),  Convert the color of the pixel to a grayscale value by averaging the RGB components, creates the ASCII representation based on the pixel's grayscale intensity,
- must desplay a clear ASCII image 

# filter_questions class
-- this class allow the user to ask questions related to cybersecurity awerness and it must respond as accurecty as possable 

# what does it contains?
- constructore
- ArrayList  
- while loop 
- if else
- foreach loop
- splitter function 
- filtter function


## Features
- **Continuous Interaction**:
  - The bot continuously prompts the user to ask questions until they type `exit`.
  
- **Question Filtering**:
  - Filters unnecessary words like "what," "how," "tell," etc., to focus on keywords.
  
- **Answer Matching**:
  - Predefined cybersecurity-related answers are stored in the bot. It selects the best match based on user input.

- **Friendly User Interaction**:
  - Provides a welcoming message and color-coded responses for better readability.

- **Exit Command**:
  - Users can type `exit` to terminate the bot.

---

## **How It Works**
1. **User Prompt**:
   - The bot asks the user for their name and welcomes them.

2. **Input Processing**:
   - User input is split into individual words, and irrelevant words are removed using a predefined ignore list.

3. **Answer Matching**:
   - The bot compares filtered user input with stored answers and selects the most relevant response.

4. **Output**:
   - If a match is found, the bot outputs the corresponding response.
   - If no match is found, the bot suggests asking cybersecurity-related questions.

---

## **Predefined Responses**
The bot includes the following predefined responses:
1. "My purpose is to teach you more about cybersecurity and the risks that come with the lack of knowledge about cyber attacks and threats."
2. "You can ask about anything related to cybersecurity awareness."
3. "Common Threat areas follow: Viruses, malware, and ransomware are some dangers in cyberspace."
4. "Phishing is a type of social engineering attack where attackers use fraudulent emails, text messages, or websites to trick individuals into revealing sensitive information like credit card details."
5. "Passwords can be protected by using strong and unique passwords. Avoid using your birthday, cellphone number, or anything that a hacker can easily guess."
6. "I'm good! How are you, and how can I assist you today?"
7. "Cybersecurity is the practice of protecting computers, networks, and data from hackers, viruses, and other cyber threats. It helps keep personal and business information safe from being stolen, damaged, or misused."
8. "To protect yourself from phishing attacks, immediately report suspicious emails and stay informed about the latest phishing scams."
9. "Hi! How are you? How can I assist you today?"

---

## **Ignored Words**
To focus on meaningful keywords, the bot ignores the following common words:
- "your"
- "can"
- "how"
- "what"
- "tell"
- "about"
- "are"
- "me"
- "more"

---

## **Installation**

   ```bash
   git clone <https://github.com/ST456076/part1_programming_poe.git>


