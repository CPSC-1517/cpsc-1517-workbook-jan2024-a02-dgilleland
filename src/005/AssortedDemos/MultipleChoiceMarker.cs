namespace Assorted;

public class MultipleChoiceMarker
{
    public List<MultipleChoice> Key { get; }
    public int Count { get; }
    public MultipleChoiceMarker(List<MultipleChoice> key)
    {
        // TODO: Validation
        Key = key;
    }
    public Mark MarkExam(List<MultipleChoice> studentAnswers)
    {
        // TODO: Validation
        // Loop through the student answers and compare them against the key
        int correct = 0;
        for(int index = 0; index < Key.Count; index++)
        {
            var keyItem = Key[index];
            var student = studentAnswers[index];
            if(student.Choice != MultipleChoice.Answer.NOT_ANSWERED)
            {
                if(keyItem.Choice == student.Choice)
                    correct++;
            }
        }
        return new Mark(Key.Count, correct);
    }
}