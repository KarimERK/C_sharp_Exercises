using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            int min = 0;
            int max = 10;
            int secretNum = new Random().Next(min, max);
            int guess;

            Console.WriteLine("Guess the number between 1-10 ");
            guess = int.Parse(Console.ReadLine());
            if (guess > secretNum)
            {
                Console.WriteLine("Too High!");
            }
            else if (guess < secretNum)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("Congratulations you guessed right! ");
               
            }
        }
        
    }
}