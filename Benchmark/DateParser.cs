namespace BenchmarkExample;

public class DateParser
{
    public int GetYearFromDateTime(string dateTime)
    {
        return DateTime.Parse(dateTime).Year;
    }
    
    public int GetYearFromSplitString(string dateTime)
    {
        return int.Parse(dateTime.Split('-')[0]);
    }
}