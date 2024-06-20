using System.IO; 

public class Journal{
    
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        foreach (var entry in _entries){
            entry.Display();
        }
    }
    public void SaveToFile(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (var entry in _entries){
                outputFile.WriteLine($"{entry._date} > Prompt: {entry._promptText}");
                outputFile.WriteLine($"Response: {entry._entry}");
                outputFile.WriteLine();
            }
        }
    }
    public void LoadFromFile(string file){
         _entries.Clear();    
        using (StreamReader inputFile = new StreamReader(file)){
            string line;
            string currentPrompt = "";
            string currentResponse = "";
            string currentDate = "";
            while ((line = inputFile.ReadLine()) != null){
                if (line.EndsWith(" >"))    {
                    currentDate = line.Substring(0, line.IndexOf(" >"));
                    currentPrompt = line.Substring(line.IndexOf("> ") + 2);
                }
                else if (line.StartsWith("Response: ")){
                    currentResponse = line.Substring("Response: ".Length);
                     _entries.Add(new Entry(currentPrompt, currentResponse, currentDate));
                }
            }
        }
    }

}