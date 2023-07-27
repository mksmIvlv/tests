using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class SearchInCollectionBenchmark
{
    #region Поле

    private SearchInCollection _searchInCollection;

    #endregion

    #region Конструктор

    public SearchInCollectionBenchmark()
    {
        _searchInCollection = new SearchInCollection();
    }

    #endregion

    #region Методы
    
    [Benchmark]
    public int BinarySearchBenchmark()
    {
        var array = new double[] { -9, 0, 2.0, 3.0 };
        var item = 100;
        
        return _searchInCollection.BinarySearch(array, item);
    }
    
    [Benchmark]
    public int MaximumNumberInTheArrayBenchmark()
    {
        var array = new int[] { 1, 100, 200, -300 };

        return _searchInCollection.MaximumNumberInTheArray(array);
    }
    
    [Benchmark]
    public int MinimumNumberInTheArrayBenchmark()
    {
        var array = new int[] { 1, 100, 200, -300 };

        return _searchInCollection.MinimumNumberInTheArray(array);
    }
    
    [Benchmark]
    public double AverageValueInTheArrayBenchmark()
    {
        var array = new int[] {-1, -5, -51, -1};

        return _searchInCollection.AverageValueInTheArray(array);
    }
    
    [Benchmark]
    public int ProfitableClientBenchmark()
    {
        var array = new int[][]
        {
            new int[] { 95, 67, 13, 55, 44, 11, 10 },
            new int[] { 7, 190, 4, 44, 11, 1, 99 },
            new int[] { 0, 5, -1, 500, 14, 90, 1 }
        };
        
        return _searchInCollection.ProfitableClient(array);
    }
    
    [Benchmark]
    public int AvoidJailDueToTaxFraudBenchmark()
    {
        var report = new int[][]
        {
            new int[] { 95, 67, 13, 55, 44, 11, 15 },
            new int[] { 0, 1, 2, 4, 6, 8, 10 },
            new int[] { -7, -5, -1, -10, 14, 90 }
        };

        return _searchInCollection.AvoidJailDueToTaxFraud(report);
    }

    #endregion
}