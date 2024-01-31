namespace Assorted;

public class Angle
{
    public double Degrees { get; set; }
    public double Radians
    {
        get
        {
            return Degrees * (Math.PI / 180);
        }
    }

    // The property below is written as a Lambda Expression
    public double Grads => Radians * (200 / Math.PI);
    //                  \/ \_____ Return Value ____/
    //                  |
    //                  | Lambda operator  =>   "such that", "produces"
    //  The Grads property produces the value of (expression)

    public AngleType Type
    {
        get
        {
            // TODO: Build out solution as I make tests
            return default;
        }
    }

    public Angle(double degrees)
    {
        Degrees = degrees;
    }
}
