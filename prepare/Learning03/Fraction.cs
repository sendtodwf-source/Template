public class Fraction
{
    //Create attributes
    private int top;
    private int bottom;

    //Create constructors
    public Fraction ()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int topc)
    {
        top = topc;
        bottom = 1;
    }
    public Fraction ( int topc, int bottomc)
    {
        top = topc;
        bottom = bottomc;
    }

    //Create Getters
    public int GetTop()
    {
        return top;
    }
    public int GetBottom()
    {
        return bottom;
    }
    public string GetFractionString()
    {
        string fractStr = $"{top}/{bottom}";
        return fractStr;
    }
    public double GetDecimalValue()
    {
        double fract = (double)top/(double)bottom;
        return fract;
    } 

    public void SetTop(int topc)
    {
        top = topc;
    }
    public void SetBottom(int bottomc)
    {
        bottom = bottomc;
    }

        



}