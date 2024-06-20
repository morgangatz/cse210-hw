using System.IO; 

public class Journal{
    
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry){

    }
    public void DisplayAll(){

    }
    public void SaveToFile(string file){
        Console.WriteLine("Enter file name: ");
        file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file)){
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
    }
    }
    public void LoadFromFile(string file){

    }

}