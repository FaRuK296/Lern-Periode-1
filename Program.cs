using System.ComponentModel.Design;

namespace LA1_numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int guessAttepmts = 0;
            bool hasGuessedNumber = false;
            int guessedNumber;
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("I've picked a number between 1 and 100. Try to guess it!");
            while (!hasGuessedNumber)
            {
                Console.Write("Enter a number between 1 and 100: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out guessedNumber) && guessedNumber >= 1 && guessedNumber <= 100)
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
                        Console.WriteLine("You've had {0} guesses.", guessAttepmts);
                        hasGuessedNumber= true;

                    }

          

                }

            }
        }
    }
}
    

                
    

