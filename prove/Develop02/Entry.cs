public class Entry
{
    string date;
    string prompt;
    string response;
    
    public void Display()
    {
        Console.WriteLine($"date: {date}\nPrompt: {prompt}\n Response: {response}");
        
    }
}