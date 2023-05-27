class EndGame
{
    public void EndGameScreen()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@" ========================================= ");
        Console.WriteLine(@"||  ______   _______   __   ________     ||");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"|| |%%%%%%| |%%%%%%%| |%%| |%%%%%%%%%\   ||");
        Console.WriteLine(@"|| |%%%%__| |%%%%%%%| |%%| |%%%%%%%%%%\  ||");
        Console.WriteLine(@"|| |%%%|__  |%%%%%%%| |%%| |%%%%___%%%%\ ||");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"|| |%%%%%%| |%%%_%%%| |%%| |%%%|   |%%%| ||");
        Console.WriteLine(@"|| |%%%%%%| |%%| |%%| |%%| |%%%|   |%%%| ||");
        Console.WriteLine(@"|| |%%% __| |%%| |%%| |%%| |%%%|___|%%%| ||");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"|| |%%%|    |%%| |%%| |%%| |%%%%%%%%%%%| ||");
        Console.WriteLine(@"|| |%%%|__  |%%| |%%|_|%%| |%%%%%%%%%%%/ ||");
        Console.WriteLine(@"|| |%%%%%%| |%%| |%%%%%%%| |%%%%%%%%%%/  ||");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"|| |______| |__| |_______| |_________/   ||");
        Console.WriteLine(@"||                                       ||");
        Console.WriteLine(@" ========================================= ");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The Game Has Come To An End!\nWould You Like To Play Again?");
        Console.Write("Enter Y for Yes or N for No: ");

        string userPlayAgain = Console.ReadLine();

        // instantiate a tries variable
        int tries = 3;

        if (userPlayAgain.ToLower() == "y")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Restarting Game. Please Wait...");
            Thread.Sleep(2000);
            Console.Clear();

            MainMenu mainMenu = new();
            mainMenu.DifficultySelection();
        }
        else if (userPlayAgain.ToLower() == "n")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You've Entered N for No. Closing Game. Please Wait...");
            Thread.Sleep(2000);

            Environment.Exit(0);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Selection. Please Enter Y or N To Play Again");
            Thread.Sleep(2000);

            // decrement tries by 1
            tries--;

            if (tries > 0)
            {
                // allow user to try again
                EndGameScreen();
            }
            else
            {
                // exit program to prevent unnecessary loop
                Environment.Exit(0);
            }    
        }
    }
}