using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal ();
        Entry anEntry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        Console.WriteLine(prompt.GetRandomPrompt());
        //Console.WriteLine("Hello Develop02 World!");
        int num = 0;

        while(num != 5){
            Console.WriteLine("Please select one: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();
            num = int.Parse(choice);

            if(num == 1){
                Console.WriteLine(prompt.GetRandomPrompt());
            }
            else if(num == 2){

            }
            else if(num == 3){

            }
            else if(num == 4){

            }

        }

    }
}