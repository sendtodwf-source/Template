public class Entry //A custom data type (object) to hold all the information that is important for what would be a real life journal entry
{
    public string _date = ""; // Entry date
    public string _prompt; // The question the user was asked
    public string _response; // The response to that question or prompt
    
    public void Display() // A way to display the data in a loaded 'Entry' object
    {
        Console.WriteLine($"date: {_date}\nPrompt: {_prompt}\n Response: {_response}");
        
    }
}