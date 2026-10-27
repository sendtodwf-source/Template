class Scripture
{
    private Reference refer;
    private List<Word> _words = new List<Word>();
    public int _wordsHidden;
    public Scripture(string verses, Reference refHead)
    {
        refer = refHead;
        string [] vSplit = verses.Split(" ");
        //Word w = new Word();
        foreach (string t in vSplit)//Condensing the words into "word" objects
        {
            Word w = new Word();
            w.setWord(t); //The problem is that every time we set the word that it is a global varible
            _words.Add(w); 
        }
    }
    public bool Hide()
    {
        bool moreToHide = true;
        int hideAmount = 3; //How many words we will hide]
        int cur = 0;
        int count = 0;
        int listLen = _words.Count;
        Random rand = new Random();
        //Word w = new Word();
        //foreach(Word w in _words)// this loop randomly hides the words in the scripture verse

        while (cur < listLen && count < hideAmount)
        {
            Word w = _words[cur];
            {
                if (!isNum(w.getWord()))//make sure that this isn't a numbe we are hiding
                {
                    if (!w.isHidden() && count < hideAmount)//make sure that we can change the value to hidden
                    {
                        if (rand.Next(0,1000) < 500)//randomly choose ~50% chance to change
                        {
                            w.Hide();
                            count += 1; // update the amount we have hidden locally
                            _wordsHidden += 1; //update the amount we have hidden globally
                        }
                    }
                }
            }
            cur +=1;
        }
        if (listLen < count)
        {
            moreToHide = true;
        }
        return moreToHide;
    }
    public void Display()
    {
        Console.WriteLine($"{refer.GetRefConc()}\n");
        foreach (Word word in _words)
        {
            Console.Write($" {word.getWord()}");
        }
    }
    public bool isNum(string spc)
    {
        bool fact = false;
        foreach(char s in spc)
        {
            if(int.TryParse(s.ToString(), out _))
            {
                fact = true;
            }
        }
        return fact;
    }
}