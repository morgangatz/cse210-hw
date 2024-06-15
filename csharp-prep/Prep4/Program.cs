using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        
        int userNum = -1;
        while (userNum != 0){
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);
    
            if (userNum != 0){
                numbers.Add(userNum);
            }
        }

        int total= 0;
        foreach (int number in numbers){
            total += number;
        }

        Console.WriteLine($"The total is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers){
            if (number > max){
                max = number;
            }
        }

        Console.WriteLine($"The max number is: {max}");
    }
}