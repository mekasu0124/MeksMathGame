class GameBrain
{
    public void LaunchSequence(string difficulty, string game, int numOfQues)
    {
        Console.ForegroundColor = ConsoleColor.White;

        // instantiate a tries variable
        int tries = 3;

        switch (game)
        {
            case "addition":
                AdditionGame addGame = new AdditionGame();
                addGame.StartGame(difficulty, numOfQues);
                break;

            case "subtraction":
                SubtractionGame subGame = new SubtractionGame();
                subGame.StartGame(difficulty, numOfQues);
                break;

            case "multiplication":
                MultiplicationGame multGame = new MultiplicationGame();
                multGame.StartGame(difficulty, numOfQues);
                break;

            case "division":
                DivisionGame divGame = new DivisionGame();
                divGame.StartGame(difficulty, numOfQues);
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(
                    "Invalid Operation Starting Desired Game. Re-Launching Game Launch Sequence. " +
                    "If This Problem Persists, Then Contact Support At: " +
                    "https://github.com/mekasu0124/MeksMathGame/issues"
                );

                Thread.Sleep(2000);

                // decrement tries by 1
                tries--;

                if (tries > 0)
                {
                    // allow the program to try again
                    LaunchSequence(difficulty, game, numOfQues);
                }
                else
                {
                    // exit the program to prevent unecessary loop
                    Environment.Exit(0);
                }
                break;
        }
    }
}