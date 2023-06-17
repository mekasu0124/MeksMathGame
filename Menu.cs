namespace MeksMathGameRewrite
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();

            bool isGameOn = true;

            do
            {
                Console.Clear();

                List<string> strings = new()
                {
                    "--------------------------------\n",
                    $"Hello {name}. It's {date}.\nWelcome To Your Math Game.\n",
                    "\n",
                    "What game would you like to play today? Choose from the options below:\n",
                    "A - Addition\n",
                    "S - Subtraction\n",
                    "M - Multiplication\n",
                    "D - Division\n",
                    "Q - Quit Game\n",
                    "V - Previous Games\n",
                    "\n",
                    "---------------------------------\n",
                    "Your Selection: "
                };

                Helpers.typewriter(strings);

                var gameSelected = Console.ReadLine();
                gameSelected = Helpers.GetGame(gameSelected);

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        gameEngine.AdditionGame("Addition Game");
                        break;

                    case "s":
                        gameEngine.SubtractionGame("Subtraction Game");
                        break;

                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Game");
                        break;

                    case "d":
                        gameEngine.DivisionGame("Division Game");
                        break;

                    case "q":
                        Console.WriteLine("Exiting Application");
                        isGameOn = false;
                        break;

                    case "v":
                        Helpers.PrintGames();
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }

        string GetName()
        {
            string getName = "Enter Your Name";

            var name = Console.ReadLine();
            return name;
        }
    }
}
