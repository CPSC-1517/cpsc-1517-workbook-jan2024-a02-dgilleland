namespace Assorted;
using static System.Text.EnumParser;
public class Exam
{
    public string Name { get; }
    public List<MultipleChoice> Questions { get; }
    private Exam(string name)
    {
        Name = name;
        Questions = new();
    }

    /// <summary>
    /// Generate an Exam from a string of text
    /// </summary>
    /// <param name="text">Comma-delimited string of Exam information</param>
    /// <returns>An <see cref="Exam"/> object</returns>
    /// <remarks>
    /// The format of the string is expected to have the student name as the first delimited item
    /// and all the remaining items to be answers of the form A through E. Blanks are allowed.
    /// E.g.:
    /// <code>Stewart Dent,A,C,B,D,D,,E</code>
    /// </remarks>
    public static Exam Parse(string text)
    {
        // Split the text by commas to generate the Exam information
        string[] parts = text.Split(',');
        Exam result = new(parts[0]);
        string[] remaining = parts.Skip(1).ToArray();
        foreach(string item in remaining)
        {
            MultipleChoice.Answer answer;
            if(TryParse(item, out answer))
                result.Questions.Add(new(answer));
            else
                result.Questions.Add(new()); // not-answered question
        }
        return result;
    }
}