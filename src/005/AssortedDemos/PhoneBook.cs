namespace Assorted;

public class PhoneBook
{
    public List<PhoneNumber> Numbers { get; }
    public string Name { get;}
    public PhoneBook(string areaName)
    {
        Name = areaName;
        Numbers = new(); // empty list
    }
    public void Add(PhoneNumber entry)
    {
        // TODO: entry should not be null
        Numbers.Add(entry);
    }
    public List<PhoneNumber> Find(string partialLastName)
    {
        throw new NotImplementedException();
    }

    public PhoneNumber FindByNumber(string number)
    {
        PhoneNumber found = null;
        foreach(PhoneNumber entry in Numbers)
            if(entry.Number == number)
                found = entry;
        return found;
    }
}
