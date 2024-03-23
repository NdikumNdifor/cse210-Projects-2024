public class Word
{
  /*  private bool _shown;
    private string _word;

    public Word(string word)
    {
        _shown= true;
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }
    public bool GetShown()
    {
        return _shown;
    }
    public void SetHidden()
    {
        _shown = false;
    }                       */

    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}   




