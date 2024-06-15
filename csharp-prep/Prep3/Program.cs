using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int randNumber = randomGenerator.Next(1, 101);

        int guess = 0;
        
        while(guess != randNumber){
            Console.Write("Guess the number: ");
            guess = int.Parse(Console.ReadLine());
            
            if (randNumber > guess){
                Console.WriteLine("Higher");
            }

            else if (randNumber < guess){
                Console.WriteLine("Lower");
            }

            else{
                Console.WriteLine("You got it!");
            }
        }
    }
}