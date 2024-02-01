namespace Assorted;

/// <summary>
/// Represents a selection of an option for a multiple-choice question.
/// </summary>
public class MultipleChoice
{
    public enum Answer { NOT_ANSWERED, A, B, C, D, E }

    public Answer Choice { get; }

    public MultipleChoice()
    {
        Choice = Answer.NOT_ANSWERED;
    }

    public MultipleChoice(Answer chosenAnswer)
    {
        Choice = chosenAnswer;
    }
}
