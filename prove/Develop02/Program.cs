using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal ();
        PromptGenerator prompt = new PromptGenerator();

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
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                theJournal.AddEntry(new Entry(randomPrompt, response));
            }
            else if(num == 2){
                theJournal.DisplayAll();
            }
            else if(num == 3){
                Console.Write("Enter file name to load: ");
                string loadFileName = Console.ReadLine();
                theJournal.LoadFromFile(loadFileName);
            }
            else if(num == 4){
                Console.Write("Enter file name to save: ");
                string saveFileName = Console.ReadLine();
                theJournal.SaveToFile(saveFileName);
            }

        }

    }
}