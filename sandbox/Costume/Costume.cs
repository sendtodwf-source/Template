namespace Costume;
class Costume
{
    //attrubutes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footware;
    public string _accessories;

    //behaviors
    public void Output()
    {
        Console.WriteLine("Costume pieces:");
        Console.WriteLine($"head: {_headwear}");
        Console.WriteLine($"torso: {_upperGarment}");
        Console.WriteLine($"head: {_lowerGarment}");
        Console.WriteLine($"head: {_footware}");
        Console.WriteLine($"head: {_accessories}");

    }
}