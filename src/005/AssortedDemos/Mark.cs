namespace Assorted;

/// <summary>
/// Represents a Mark on a assignment or quiz
/// </summary>
public class Mark
{
    public int Possible { get; }
    public int Earned { get; }
    public double Average { get { return 100.0 * Earned / Possible; } }

    public Mark(int possible, int earned)
    {
        // TODO: Validation
        Possible = possible;
        Earned = earned;
    }
}
