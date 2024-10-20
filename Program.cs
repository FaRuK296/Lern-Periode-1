﻿using System;
using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace LA1_numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // radom number generator
            Random random = new Random();

            // variables for the game
            int secretNumber = 0;
            int guessAttepmts = 0;
            bool hasGuessedNumber = false;
            int maxGuesses = int.MaxValue;
            int lowerLimit = 1;
            int upperLimit = 100;

            // difficulty level
            Console.WriteLine("Pick a difficulty level: ");
            Console.WriteLine("1 - Easy (Number between 1 and 100, unlimited attepmts)");
            Console.WriteLine("2 - Medium (Number between 1 and 500, 15 attepmts)");
            Console.WriteLine("3 - Hard (Number between 1 and 1000, 10 attepmts)");
            Console.Write("Enter the number of the difficulty you want: ");

            string difficultyChoise = Console.ReadLine();




            // Alte Methode mit int-Konvertierung und Vergleich
            /*
            // set difficulty level
            



             Console.Write("Enter the number of the difficulty you want: ")
             string difficultyChoice = Console.ReadLine();
             int difficultyChoiceInt;
             if (int.TryParse(difficultyChoice, out difficultyChoiceInt))
{
          switch (difficultyChoiceInt)
    {
        case 1: // easy
            upperLimit = 100;
            maxGuesses = int.MaxValue; // unlimited attempts
            break;

        case 2: // medium
            upperLimit = 500;
            maxGuesses = 15; // 15 attempts
            break;

        case 3: // hard
            upperLimit = 1000;
            maxGuesses = 10; // 10 attempts
            break;

        default:
            Console.WriteLine("Invalid selection, simple mode is used.");
            upperLimit = 100;
            maxGuesses = int.MaxValue;
            break;
    }
}
else
{
    Console.WriteLine("Invalid input, please enter a number.");
}
*/

            /*
            // Neue Methode mit string-Eingabe für die Schwierigkeitsauswahl
            
            Console.Write("Enter the difficulty (easy, medium, hard): ");
            string difficultyChoice = Console.ReadLine().ToLower();

            switch (difficultyChoice)
            {
                case "easy":
                    upperLimit = 100;
                    maxGuesses = int.MaxValue;
                    break;

                case "medium":
                    upperLimit = 500;
                    maxGuesses = 15;
                    break;

                case "hard":
                    upperLimit = 1000;
                    maxGuesses = 10;
                    break;

                default:
                    Console.WriteLine("Invalid selection, simple mode is used.");
                    upperLimit = 100;
                    maxGuesses = int.MaxValue;
                    break;
            }

            */



            // Kombinierte Methode für Nummern und Strings
            Console.Write("Enter the difficulty (1, 2, 3, easy, medium, hard): ");
            string difficultyChoice = Console.ReadLine().ToLower();
            int difficultyChoiceInt;
            bool isInt = int.TryParse(difficultyChoice, out difficultyChoiceInt);

            if (isInt)
            {
                // Fall für numerische Eingaben
                switch (difficultyChoiceInt)
                {
                    case 1:
                        upperLimit = 100;
                        maxGuesses = int.MaxValue;
                        break;

                    case 2:
                        upperLimit = 500;
                        maxGuesses = 15;
                        break;

                    case 3:
                        upperLimit = 1000;
                        maxGuesses = 10;
                        break;

                    default:
                        Console.WriteLine("Invalid selection, simple mode is used.");
                        upperLimit = 100;
                        maxGuesses = int.MaxValue;
                        break;
                }
            }
            else
            {
                // Fall für string-basierte Eingaben
                switch (difficultyChoice)
                {
                    case "easy":
                        upperLimit = 100;
                        maxGuesses = int.MaxValue;
                        break;

                    case "medium":
                        upperLimit = 500;
                        maxGuesses = 15;
                        break;

                    case "hard":
                        upperLimit = 1000;
                        maxGuesses = 10;
                        break;

                    default:
                        Console.WriteLine("Invalid selection, simple mode is used.");
                        upperLimit = 100;
                        maxGuesses = int.MaxValue;
                        break;
                }
            }






            // generate secret number
            secretNumber = random.Next(lowerLimit, upperLimit + 1);


            // game starts
            Console.WriteLine($"Welcome to the guessing game! Guess the number between {lowerLimit} and {upperLimit}. ");

            while (!hasGuessedNumber && guessAttepmts < maxGuesses)
            {
                Console.Write($"Attempt {guessAttepmts + 1}/{maxGuesses}: Please enter a number between {lowerLimit} and {upperLimit}: ");
                string input = Console.ReadLine();
                int guessedNumber;



                // Try to convert the input into a number and check whether it is within the valid range
                if (int.TryParse(input, out guessedNumber) && guessedNumber >= lowerLimit && guessedNumber <= upperLimit)
                {
                    guessAttepmts++;

                    if (guessedNumber > secretNumber)
                    {
                        Console.WriteLine("Your number is too high");
                    }


                    else if (guessedNumber < secretNumber)

                    {
                        Console.WriteLine("Your number is too low");

                    }
                    else
                    {
                        Console.WriteLine("Congrats, you've guessed the secret number!");
                        Console.WriteLine($"You've had {guessAttepmts} guesses.");
                        hasGuessedNumber = true;
                    }
                }


                else
                {
                    Console.WriteLine($"Invalid section. Please enter a number between {lowerLimit} and {upperLimit}. ");

                }

            }

                        {

                // If the number hasn't been guessed and the Attempts are over
                if (!hasGuessedNumber)
                       
                    {
                            Console.WriteLine("Unfortunately, you've reached the maximum number of attempts. You've lost!");
                            Console.WriteLine($"The secret number was {secretNumber}");
                        }


                }
                    
                }
            }
        }
    





                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    

          

                

            
        
    

    

                
    

