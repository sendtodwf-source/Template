public class Word
{
  private string _word;
  private bool _isHidden;

  public Word()
    {
        _word = "";
        _isHidden = false;
    }

  public Word(string inWord)
    {
        _word = inWord;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
        string under = "";
        foreach (char letter in _word)
        {
           under+="_"; 
        }
        _word = under;
    }
    public bool isHidden()
    {
        return _isHidden;
    }
    public string getWord()
    {
        return _word;
    }
    public void setWord(string inWord)
    {
        
        _word = inWord;
        _isHidden = false;
    }
}