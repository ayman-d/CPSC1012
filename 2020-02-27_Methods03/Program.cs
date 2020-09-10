using System;

namespace _2020_02_27_Methods03
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            do
            {
                userAnswer = "";
                DisplayMenu();
                // get user input
                int userInput = GetUserInput();
                // play selected game
                PlayGame(userInput);
                // re-display menu & ask user to play again
                if (userInput > 0 && userInput < 4)
                {
                    Console.Write("Do you want to play another game (yes/no)? ");
                    userAnswer = Console.ReadLine();
                }
            } while (userAnswer.ToLower() == "yes");
            Console.WriteLine("Thanks for playing!");


            // for looks
            Console.ReadLine();
        } // end Main() method

        static void DisplayMenu()
        {
            Console.WriteLine("Welcome! Choose a game from the below list:\n" +
            "\n     1. Number Guesser" +
            "\n     2. Addition Quiz" +
            "\n     3. Rock Paper Scissors" +
            "\ntype any other number to exit the program");
        } // end of DisplayMenu() method

        static int GetUserInput()
        {
            bool valid = false;
            int userInput = 0;

            do
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Sorry, wrong input. please select a number from the above menu");
                }
            } while (!valid);

            return userInput;

        }

        static void PlayGame(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    NumberGuesser();
                    break;
                case 2:
                    AdditionQuiz();
                    break;
                case 3:
                    RockPaperScissors();
                    break;
                default:
                    break;
            }
        }

        static void NumberGuesser()
        {
            Random rand = new Random();
            int randomInt = rand.Next(1, 6);
            Console.Write("Guess a number between 1 to 5: ");
            int userGuess = GetUserInput();
            Console.WriteLine((userGuess == randomInt) ? "Correct!" : "Sorry, wrong guess :(");
        }

        static void AdditionQuiz()
        {
            Console.Write("How many math puzzles do you want to solve?: ");
            int numberOfQuestions = GetUserInput();
            int counter;
            int correctAnswers = 0;

            for (counter = 0; counter < numberOfQuestions; counter++)
            {
                Random rand = new Random();
                int firstNum = rand.Next(1, 11);
                int secondNum = rand.Next(1, 11);

                Console.Write($"What is the sum of {firstNum} and {secondNum}? ");
                int userAnswer = GetUserInput();
                if (userAnswer == (firstNum + secondNum))
                {
                    correctAnswers++;
                }
            }
            Console.WriteLine($"You got {correctAnswers} out of {numberOfQuestions} correctly!");
        }

        static void RockPaperScissors()
        {
            Random rand = new Random();
            int randomChoice = rand.Next(1, 4);
            string hand = NumToRPS(randomChoice);
            
            //Console.WriteLine(hand);

            Console.WriteLine($"choose your hand!" + "\n1. rock" + "\n2. paper" + "\n3. scissors");
            int playerChoice = int.Parse(Console.ReadLine());
            string playerHand = NumToRPS(playerChoice);

            if (playerChoice == randomChoice)
            {
                Console.WriteLine($"It's a tie! we both chose {playerHand}");
            }
            else
            {
                bool win = false;
                switch (playerChoice)
                {
                    case 1:
                        win = randomChoice == 2 ? false : true;
                        break;
                    case 2:
                        win = randomChoice == 1 ? true : false;
                        break;
                    case 3:
                        win = randomChoice == 1 ? false : true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(win ? $"you win! {playerHand} beats {hand}" : $"you lose! {hand} beats {playerHand}");
            }


        }

        static string NumToRPS(int input)
        {
            string hand = "";
            switch (input)
            {
                case 1:
                    hand = "rock";
                    break;
                case 2:
                    hand = "paper";
                    break;
                case 3:
                    hand = "scissors";
                    break;
                default:
                    break;
            }
            return hand;
        }

    }
}
