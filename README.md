# MeksMathGame

<details>
    <summary>Table Of Contents</summary>

- [Introduction](#introduction)
- [Installation](#installation)
- [How To Play](#how-to-play)
- [Need Support](#need-support)
- [Future Updates](#future-updates)
</details>

# Introduction

Hi there and welcome to Mek's Math Game! A fun and simple console-based math game for all ages. This game includes the four basic math concepts of Addition, Subtraction, Multiplication, and Division. All answers are given in the form of an [integer](https://www.techtarget.com/whatis/definition/integer), yes even the division answers. For example: If you are given the math problem of 8 divided by 10, your answer would be 0.6 and some change, but the answer you would submit is simply 0 (zero). This program was created from [The C# Academy](https://www.thecsharpacademy.com/#) as a beginner style program for those (me) that are learning the [C# Programming Language](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/). This project is mean to be for pure fun and enjoyment.

# Installation

#### If you're wanting to compile from source

To install this program, you will need to make sure that you have [Git](https://git-scm.com/downloads) and [C#](https://www.microsoft.com/en-us/download/details.aspx?id=7029) installed, then you'll need to open your terminal.

<details>
    <summary>Steps For Your OS</summary>

- If you're on windows, [follow these steps](https://www.computerworld.com/article/3676596/how-to-manage-and-customize-windows-terminal.html#:~:text=Launching%20Windows%20Terminal)
- If you're on mac, [follow these steps](https://support.apple.com/guide/terminal/open-or-quit-terminal-apd5265185d-f365-44cb-8b09-71a064a42125/mac#:~:text=Terminal%20for%20me-,Open%20Terminal,%2C%20then%20double-click%20Terminal.)
- If you're on linux, [follow these steps](https://www.makeuseof.com/how-to-open-terminal-in-linux/#:~:text=Use%20Keyboard%20Shortcuts%20to%20Open%20the%20Linux%20Terminal&text=If%20you%20are%20a%20fan,to%20fire%20up%20the%20terminal.)
</details><br />

and change your directory to the desired download location. The [change directory](https://www.lifewire.com/change-directories-in-command-prompt-5185508#:~:text=Type%20cmd%20into%20the%20Windows%2011%20or%20Windows%2010%20search,directory%20changes%20don%27t%20work.) command is the same no matter the OS. Once you're in the desired location, you'll then type `git clone https://github.com/mekasu0124/MeksMathGame.git`. After the clone has finished, change directory into the projects folder, then run `dotnet run` to start the application. From here, the game will take over the same console window and will start running on its own.

#### If you're wanting to get the executable file

- If you're on Windows, you'll click [this link](https://github.com/mekasu0124/MeksMathGame/blob/master/Builds/WindowsBuild/MeksMathGame.exe) and then click the download button to download the executable file.
- If you're on Mac, you'll click [this link](https://github.com/mekasu0124/MeksMathGame/blob/master/Builds/MacBuild/MeksMathGame) and then click the download button to download the mac version executable file.
- If you're on Linux, you'll click [this link](https://github.com/mekasu0124/MeksMathGame/blob/master/Builds/LinuxBuild/MeksMathGame) and then click the download button to download the linux version of the executable file.

# How To Play

The game initially launches with a welcome screen explaining how the game operates, what the desired inputs are, and tells the user to enter `yes` if they're ready to play or `no` if they want to exit the game. In any part of the applicaiton that requests user input, if you input any other than the desired entry, you'll get an error screen. That error screen will only show 3 times and then the program will exit. If you *are* entering the desired input and are still seeing the error screen, then you'll need to go down to the [Need Support?](#need-support?) section of this read me file and see how to post your issues to the issues tab of the repository so that I can figure out the problem, and help find a solution. I digress, the game is simple. It asks the user if they're ready to play, then to select a difficulty level, then to select the game they want to play, and how many questions they want to answer. From there, the computer grabs random numbers and presents the user with a math question to which they'll need to answer. **This game is still under developement. There are currently no re-tries on answers. This will be implemented at a later date as I become more rounded with C#.** After you've answered the desired amount of questions, the game will end and an End Game Screen will display asking the user a `yes` or `no` question on whether they would like to play again.

# Need Support

In the event that the game starts to mess up, you're welcome to post your issue on the [issues](https://github.com/mekasu0124/MeksMathGame/issues) page. Before you post an issue to the issues page, please be sure that you have read the [guide on posting a good issue](https://github.com/codeforamerica/howto/blob/master/Good-GitHub-Issues.md) so that you can ensure that your issue is seen and responded to. I'm not a dick, and I'm not going to purposefully ignore anyones issues, but if your issue isn't posted in a well-written manor, then it's going to lead to more questions from me than answers.

# Future Updates

- Version 2:
    - User gets multiple attempts on answering a question given that their answer is wrong.
    - Previous history screen showing previous games played (before application is closed.)

- Version 3:
    - Previous history games are written to a text file for vieweing even when game has been closed and reopened.
    - Statistics:
        - Correct Answwers
        - Wrong Answers
        - Total Questions

- Version 4:
    - Game Restructure:
        - MainMenu -> Restructured to selected elementary, middle, high school math
        - Game -> Restructured to be built around levels of math dependent on school level selection
