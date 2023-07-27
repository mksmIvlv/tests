using BenchmarkDotNet.Running;
using ProjectBenchmark;

BenchmarkRunner.Run<DecisionKataBenchmark>();
BenchmarkRunner.Run<SearchInCollectionBenchmark>();
BenchmarkRunner.Run<SortingCollectionBenchmark>();
Console.ReadKey();