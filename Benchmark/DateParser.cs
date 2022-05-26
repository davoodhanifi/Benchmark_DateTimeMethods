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

    public int GetYearFromSpan(ReadOnlySpan<char> dateTime)
    {
        return int.Parse(dateTime.Slice(0, dateTime.IndexOf('-')));
    }

    public int GetYearFromSpanWithManualConversion(ReadOnlySpan<char> dateTime)
    {
        var yearAsSpan = dateTime.Slice(0, dateTime.IndexOf('-'));
        var year = 0;

        for (int i = 0; i < yearAsSpan.Length; i++)
        {
            year = year * 10 + (yearAsSpan[i] - '0');
        }

        return year;
        
    }
}