namespace Assorted;

public class PhoneNumber
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Number { get; private set; }

    public PhoneNumber(string first, string last, string number)
    {
        FirstName = first;
        LastName = last;
        Number = number;
    }
}
