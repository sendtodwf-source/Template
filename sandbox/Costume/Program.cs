namespace Costume;
class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Costume> myCostumes = new List<Costume>();

        Costume detective = new Costume();
        detective._headwear = "fedora";
        detective._upperGarment = "trenchcoat";
        detective._lowerGarment = "slack";
        detective._footware = "dress shoes";
        detective._accessories = "fingerprint kit";

        myCostumes.Add(detective);

            foreach(Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
