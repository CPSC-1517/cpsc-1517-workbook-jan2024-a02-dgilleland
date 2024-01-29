namespace Assorted;

public class Person
{
    #region Fields (as backing stores)
    private string _FirstName;
    private string _LastName;
    #endregion

    #region Properties
    public DateTime BirthDate { get; private set; }
    public string FirstName
    {
        get { return _FirstName; }
        set
        {
            if (value.Trim() == string.Empty)
                throw new ArgumentException("First name cannot be an empty string");
            _FirstName = value.Trim();
        }
    }
    public string LastName
    {
        get { return _LastName; }
        set
        {
            if (value.Trim() == string.Empty)
                throw new ArgumentException("Last name cannot be an empty string");
            _LastName = value.Trim();
        }
    }
    public int Age
    {
        get
        {
            // TODO: Finish the actual calculation
            return -1;
        }
    }
    #endregion

    #region Constructors
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        // Guard clauses
        if(birthDate > DateTime.Today)
            throw new ArgumentOutOfRangeException("Birth dates cannot be in the future");
        // Ensure properties/fields have meaningful values
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"{FirstName} {LastName}"; // using string interpolation
    }
    #endregion
}
