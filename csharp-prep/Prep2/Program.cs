using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your percent grade?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string letter = "";

        if(grade < 60){
            letter = "F";
        }
        else if(grade >= 60 && grade < 70){
            letter = "D";
        }
        else if(grade >= 70 && grade < 80){
            letter = "C";
        }
        else if(grade >= 80 && grade < 90){
            letter = "B";
        }
        else if(grade >= 90 && grade < 101){
            letter = "A";
        }

        Console.WriteLine($"You have a/an {letter}");

        if (grade >= 70){
            Console.WriteLine("You passed the course!");
        }
        else{
            Console.WriteLine("Keep on trying!");
        }
    }
}