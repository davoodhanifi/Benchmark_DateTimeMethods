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

    public int GetYearFromSubstring(string dateTime)
    {
        return int.Parse(dateTime.Substring(0, dateTime.IndexOf('-')));
    }
}