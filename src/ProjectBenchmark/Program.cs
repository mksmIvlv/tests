using BenchmarkDotNet.Running;
using ProjectBenchmark.Benchmarks;

BenchmarkRunner.Run<DecisionKataBenchmark>();
Console.ReadKey();
BenchmarkRunner.Run<SearchInCollectionBenchmark>();
Console.ReadKey();
BenchmarkRunner.Run<SortingCollectionBenchmark>();
Console.ReadKey();