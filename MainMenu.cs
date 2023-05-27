class MainMenu
{
    public void DifficultySelection()
    {
        List<string> gameDiffs = new()
        {
            "easy",
            "medium",
            "hard"
        };

        for (int i = 0; i < gameDiffs.Count; i++)
        {
            Console.WriteLine(i + 1 + ") " + gameDiffs[i]);
        };

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Please Select A Difficulty: ");

        string userSelectDiff = Console.ReadLine();

        // instantiate a tries variable
        int tries = 3;

        if (gameDiffs.Contains(userSelectDiff))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDifficulty: " + userSelectDiff + "\n");
            Thread.Sleep(2000);
            GameSelection(userSelectDiff);
        }
        else
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(
                "Invalid Selection. Please Select From The Available Menu With All Lower " +
                "Case Spelling. If This Problem Persists, Then Contact Support At: " +
                "https://github.com/mekasu0124/MeksMathGame/issues"
            );

            Thread.Sleep(2000);

            // decrement tries by 1
            tries--;

            if (tries > 0)
            {
                // allow the user to try again
                DifficultySelection();
            }
            else
            {
                // otherwise, exit the program to prevent unecessary loop
                Environment.Exit(0);
            }
        }
    }

    public void GameSelection(string difficulty)
    {
        Console.ForegroundColor = ConsoleColor.White;

        List<string> gameTypes = new()
        {
            "addition",
            "subtraction",
            "multiplication",
            "division"
        };

        for (int i = 0; i < gameTypes.Count;i++)
        {
            Console.Write(i + 1 + ") " + gameTypes[i] + "\n");
        };

        Console.Write("\nPlease Select A Game To Play: ");

        string userSelectedGame = Console.ReadLine();

        // instantiate a tries variable
        int tries = 3;

        if (gameTypes.Contains(userSelectedGame))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDifficulty: " + difficulty + "\nGame: " +  userSelectedGame + "\n");

            GetDesiredQuestions(difficulty, userSelectedGame);
        }
        else
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(
                "Invalid Selection. Please Select From The Available Menu With All Lower " +
                "Case Spelling. If This Problem Persists, Then Contact Support At: " +
                "https://github.com/mekasu0124/MeksMathGame/issues"
            );

            Thread.Sleep(2000);

            // decrement tries by 1
            tries--;

            if (tries > 0)
            {
                // allow the user to try again
                GameSelection(difficulty);
            }
            else
            {
                // otherwise, exit the program to prevent unecessary loop
                Environment.Exit(0);
            }
        }
    }

    public void GetDesiredQuestions(string difficulty, string userSelectedGame)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nPlease Enter The Amount Of Questions You'd Like To Answer (1-100): ");

        int userDesiredQuestionAmount = Convert.ToInt32(Console.ReadLine());

        // instantiate a tries variable
        int tries = 3;

        if (userDesiredQuestionAmount > 100 | userDesiredQuestionAmount > 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "\nDifficulty: " + difficulty +
                "\nGame: " + userSelectedGame +
                "\nQuestions: " + userDesiredQuestionAmount + "\n"
            );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nLaunching Game...");
            Thread.Sleep(3000);
            Console.Clear();

            GameBrain gameBrain = new GameBrain();
            gameBrain.LaunchSequence(difficulty, userSelectedGame, userDesiredQuestionAmount);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                "Invalid Selection. Please Enter A Number Between 1 and 100. If This " +
                "Problem Persists, Then Contact Support At: " +
                "https://github.com/mekasu0124/MeksMathGame/issues"
            );

            Thread.Sleep(2000);

            // decrement tries by 1
            tries--;

            if (tries > 0)
            {
                // allow the user to try again
                GetDesiredQuestions(difficulty, userSelectedGame);
            }
            else
            {
                // exit the program to prevent unecessary loop
                Environment.Exit(0);
            }
        }
    }
}