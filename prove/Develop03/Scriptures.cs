public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _scriptureReference; 
    private string _scriptureText;
    
    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        _scriptureText = scriptureText;
        CreateWords(); 
    }

    public void CreateWords()
    {
        List<string> allWords = _scriptureText.Split(" ").ToList();
        foreach(string stringItem in allWords)
        {
            Word word = new Word(stringItem);
            _words.Add(word);
        }
    }

    public string GetScripture()
    {
        string visibleText = "";
        foreach(Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                visibleText += word.GetWord() + " ";
            }
            else
            {
                visibleText += new string('_', word.GetWord().Length) + ' ';    
            }   
        }
        return $"{_scriptureReference.GetReference()} {visibleText}";
    }

    public bool HasWordsLeft()
    {
        foreach(Word word in _words)
        {
            if(word.GetIsHidden() == false)
            {
                return true;
            }
        }
        return false; 
    }

    public void RemoveWords()
    {
        int numberOfWordsToRemove = new Random().Next(2, 3);
        int wordsRemoved = 0;

        while (wordsRemoved < numberOfWordsToRemove && HasWordsLeft()) 
        {
            int randIndex = new Random().Next(0, _words.Count());
            if (_words[randIndex].GetIsHidden() == false)
            {
                _words[randIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }
    }
}




