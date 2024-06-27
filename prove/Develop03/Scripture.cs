public class Scripture {
    private Reference Reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        Reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideRandomWords(int numberToHide){
        var random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && wordsToHide.Count > 0; i++){
            var word = wordsToHide[random.Next(wordsToHide.Count)];
            word.Hide();
            wordsToHide.Remove(word);
        }
    }
    public string GetDisplayText(){
        return $"{Reference.GetDisplayText()}\n\n" + string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
    public bool IsCompletelyHidden(){
        return _words.All(word => word.IsHidden());
    }
}