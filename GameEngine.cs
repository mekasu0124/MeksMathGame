﻿using MeksMathGameRewrite.Models;

namespace MeksMathGameRewrite
{
    internal class GameEngine
    {
        internal void DivisionGame(string message, int numOfQuestions)
        {
            var score = 0;

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var num1 = divisionNumbers[0];
                var num2 = divisionNumbers[1];

                List<string> questionText = new()
                {
                    $"Question #{i+1}\n",
                    $"{num1} / {num2}\n",
                    "Your Answer: "
                };
                Helpers.typewriter(questionText);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == num1 / num2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == (numOfQuestions - 1))
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Press Any Key To Go Back To The Main Menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
        internal void MultiplicationGame(string message, int numOfQuestions)
        {
            var random = new Random();
            var score = 0;
            int num1;
            int num2;

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                List<string> questionText = new()
                {
                    $"Question #{i+1}\n",
                    $"{num1} * {num2}\n",
                    "Your Answer: "
                };
                Helpers.typewriter(questionText);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == num1 * num2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == (numOfQuestions - 1))
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Press Any Key To Go Back To The Main Menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }
        internal void SubtractionGame(string message, int numOfQuestions)
        {
            var random = new Random();
            var score = 0;
            int num1;
            int num2;

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                List<string> questionText = new()
                {
                    $"Question #{i+1}\n",
                    $"{num1} - {num2}\n",
                    "Your Answer: "
                };
                Helpers.typewriter(questionText);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == num1 - num2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == (numOfQuestions-1))
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Press Any Key To Go Back To The Main Menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }
        internal void AdditionGame(string message, int numOfQuestions)
        {
            var random = new Random();
            var score = 0;
            int num1;
            int num2;

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);

                List<string> questionText = new()
                {
                    $"Question #{i+1}\n",
                    $"{num1} + {num2}\n",
                    "Your Answer: "
                };
                Helpers.typewriter(questionText);

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == num1 + num2)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question.");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
                    Console.ReadLine();
                }

                if (i == (numOfQuestions - 1))
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Press Any Key To Go Back To The Main Menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }
    }
}
