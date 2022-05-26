using BenchmarkDotNet.Attributes;

namespace BenchmarkExample;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class DateParserBenchmark
{
    private readonly DateParser _parser = new();
    private readonly string _dateTime = "2022-05-26T13:45:30";

    [Benchmark]
    public void GetYearFromDateTime()
    {
        _parser.GetYearFromDateTime(_dateTime);
    }

    [Benchmark]
    public void GetYearFromSplitString()
    {
        _parser.GetYearFromSplitString(_dateTime);
    }

    [Benchmark]
    public void GetYearFromSubstring()
    {
        _parser.GetYearFromSubstring(_dateTime);
    }

    [Benchmark]
    public void GetYearFromSpan()
    {
        _parser.GetYearFromSpan(_dateTime);
    }
    
    [Benchmark]
    public void GetYearFromSpanWithManualConversion()
    {
        _parser.GetYearFromSpanWithManualConversion(_dateTime);
    }
}