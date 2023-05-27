using System;
using System.Threading;

namespace MeksMathGame
{
    class Program
    {

        static void GetUserInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("When You Are Ready To Begin, Enter 'Yes' To Start, Or 'No' To Exit.\n");

            string userReady = Console.ReadLine();

            // instantiate a tries variable for else statement
            int tries = 3;

            if (userReady.ToLower() == "yes")
            {
                Console.WriteLine("Launching Main Menu...");
                Thread.Sleep(3000);
                Console.Clear();

                MainMenu mainMenu = new MainMenu();
                mainMenu.DifficultySelection();
            }
            else if (userReady.ToLower() == "no")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Exiting Game. Please Wait.");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "Invalid Operation. Please Enter 'Yes' To Start The Game" +
                    "or Enter 'No' To Exit The Game."
                );
                Thread.Sleep(1000);

                // decrement tries by 1
                tries--;
                // if tries is greater than 0
                if (tries > 0)
                {
                    // allow the user to try again
                    GetUserInput();
                }
                else
                {
                    // otherwise, exit the program to prevent unecessary loop
                    Environment.Exit(0);
                }
            }
        }

        static void SendWelcomeText()
        {
            List<string> welcomeText = new()
            {
                "Welcome To Mek's Math Game!",
                "Some Rules Of Thumb To Remember While Playing:",
                "1) All Answers Are In The Form Of An Integer.",
                "2) If Your Division Answer Gives You A Decimal Like: 0.86, Then Your Answer Is 0",
                "3) This Game Has 3 Difficulties: Easy, Medium, and Hard.",
                "4) None Of The Numbers You Will Encounter On Any Difficulty Will Go Higher Than 100.\n"
            };

            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < welcomeText.Count; i++)
            {
                Console.WriteLine(welcomeText[i]);
            };

            GetUserInput();
        }

        static void WelcomeLabel()
        {
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;

            SendWelcomeText();
        }

        static void Main(string[] args)
        {
            Console.Title = "Mek's Math Game - Version 1.0.0";
            WelcomeLabel();
        }
    }
}