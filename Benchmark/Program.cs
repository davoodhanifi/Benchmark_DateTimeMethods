using BenchmarkDotNet.Running;
using BenchmarkExample;
Console.WriteLine("Hello, World!");
BenchmarkRunner.Run<DateParserBenchmark>();

