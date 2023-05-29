using MeksMathGame;

class MainMenu
{
    public int tries = 3;

    public void InputInvalid(string error)
    {
        if (tries > 0)
        {
            tries--;
            Console.WriteLine("\n" + error + " " + tries + " Tries Left.");
        }
        else
        {
            Console.WriteLine("\nMaximum Number Attempts Reached. Exiting Program.");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }

    public void DifficultySelection()
    {
        Console.ForegroundColor = ConsoleColor.White;

        List<string> gameDiffs = new()
        {
            "easy",
            "medium",
            "hard"
        };

        foreach (string text in gameDiffs)
        {
            Console.WriteLine(text);
        };

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Please Select A Difficulty: ");

        string userSelectedDiff;

        for (int i = 0; i < 3; i++)
        {
            userSelectedDiff = Console.ReadLine();

            if (gameDiffs.Contains(userSelectedDiff))
            {
                break;
            }
            else
            {
                InputInvalid("Enter Either easy, medium, or hard");
            }
        }

        Console.WriteLine("\nDifficulty: " + userSelectedDiff);
        Thread.Sleep(2000);

        GameSelection(userSelectedDiff);
    }

    public void GameSelection(string difficulty)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");

        List<string> gameTypes = new()
        {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"
        };

        foreach (string text in gameTypes)
        {
            Console.WriteLine(text);
        };

        Console.Write("\nPlease Select A Game To Play: ");

        for (int i = 0; i < 3; i++)
        {
            string userSelectedGame = Console.ReadLine();

            if (gameTypes.Contains(userSelectedGame, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nDifficulty: " + difficulty + "\nGame: " + userSelectedGame);
                Thread.Sleep(2000);

                GetDesiredQuestions(difficulty, userSelectedGame.ToLower());
                break;
            }
            else
            {
                Console.WriteLine("Enter A Game Choice: addition, subtraction, multiplication" +
                    " Or division.");
            }
        }

        Console.WriteLine("Maximum Number Of Attempts Reached. Exiting Program. . .");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }

    public void GetDesiredQuestions(string difficulty, string userSelectedGame)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nPlease Enter The Amount Of Questions You'd Like To Answer (1-100): ");

        for (int i = 0; i < 3; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out int numOfQuestions))
            {
                Console.WriteLine("Enter An Integer, or Whole Number For Your Choice.");
            }
            else if (numOfQuestions < 1 || numOfQuestions > 100)
            {
                Console.WriteLine("Enter A Number Between 1 and 100");
            }
            else
            {
                Console.WriteLine("\nDifficulty: " + difficulty + "\nGame: " + userSelectedGame + "\nQuestions: " + numOfQuestions);
                Thread.Sleep(2000);
                LaunchGameScreen(difficulty, userSelectedGame, numOfQuestions);
                break;
            }
        }

        Console.WriteLine("Maximum Number Of Attempts Reached. Exiting Program. . .");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }

    public void LaunchGameScreen(string difficulty, string game, int numOfQuest)
    {
        switch (game)
        {
            case "addition":
                Console.WriteLine("\nLaunching Addition Game.");
                break;

            case "subtraction":
                Console.WriteLine("\nLaunching Subtraction Game.");
                break;

            case "multiplication":
                Console.WriteLine("\nLaunching Multiplication Game.");
                break;

            case "division":
                Console.WriteLine("\nLaunching Division Game.");
                break;

            default:
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Invalid Operation Launching Desired Game. Trying Again. . .");
                    Thread.Sleep(2000);
                    LaunchGameScreen(difficulty, game, numOfQuest);
                }
                Console.WriteLine("Number Of Attempts Reached. Default Back To Previous Screen.");

                Program program = new();
                program.WelcomeLabel();
                break;
        }
    }
}