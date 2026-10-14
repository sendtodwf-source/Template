public class Entry
{
    public string _date = "";
    public string _prompt;
    public string _response;
    
    public void Display()
    {
        Console.WriteLine($"date: {_date}\nPrompt: {_prompt}\n Response: {_response}");
        
    }
}