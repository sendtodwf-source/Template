public class Reference
{
    private string _book;
    private int _chapter;
    private int _sVerse;
    private int _eVerse;
    private string _cVerse;

    public Reference(string book, int chpt, int sV, int eV)
    {
        _book = book;
        _chapter = chpt;
        _sVerse = sV;
        _eVerse = eV;
        _cVerse = $"{_book} {chpt}:{sV}-{eV}";
    }
        public Reference(string book, int chpt, int sV)
    {
        _book = book;
        _chapter = chpt;
        _sVerse = sV;
        _eVerse = 0;
        _cVerse = $"{_book} {chpt}:{sV}";
    }

    public string GetBook()
    {
        return _book;
    }

    public int[] GetScrNum()
    {
        return [_chapter, _sVerse, _eVerse];
    }
    public string GetRefConc()
    {
        return _cVerse;
    } 
    public void setRef()
    {
        
    }
}
