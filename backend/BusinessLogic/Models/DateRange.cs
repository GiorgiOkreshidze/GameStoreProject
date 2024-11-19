namespace BusinessLogic.Models;

public class DateRange(DateTime start, DateTime end)
{
    public DateTime Start { get; } = start;

    public DateTime End { get; } = end;
}