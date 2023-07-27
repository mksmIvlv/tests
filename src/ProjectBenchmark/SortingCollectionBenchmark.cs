using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class SortingCollectionBenchmark
{
    #region Поле

    private SortingCollection _sortingCollection;

    #endregion

    #region Конструктор

    public SortingCollectionBenchmark()
    {
        _sortingCollection = new SortingCollection();
    }

    #endregion

    #region Методы
    
    [Benchmark]
    public double[] SortingСhoiceBenchmark()
    {
        var array = new double[] { 1, 10, -5, 5 };

        return _sortingCollection.SortingСhoice(array);

    }
    
    [Benchmark]
    public double[] QuickSortingBenchmark()
    {
        var array = new double[] { 1, -5.4, 5, 3.9 };
        
        return _sortingCollection.QuickSorting(array);
    }

    #endregion
}