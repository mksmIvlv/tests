using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class SortingCollectionBenchmark
{
    #region Поля

    /// <summary>
    /// Класс с методами для бенчмарка
    /// </summary>
    private SortingCollection _sortingCollection;

    /// <summary>
    /// Коллекция для метода SortingСhoice
    /// </summary>
    private double[] _sortingСhoice;

    /// <summary>
    /// Коллекция для метода QuickSorting
    /// </summary>
    private double[] _quickSorting;

    #endregion

    #region Конструктор

    public SortingCollectionBenchmark()
    {
        _sortingCollection = new SortingCollection();
        GeneratedData();
    }

    #endregion

    #region Методы бенчмарка
    
    /// <summary>
    /// Бенчмарк метода "Сортировка выбором"
    /// </summary>
    [Benchmark]
    public double[] SortingСhoiceBenchmark()
    {
        return _sortingCollection.SortingСhoice(_sortingСhoice);
    }
    
    /// <summary>
    /// Бенчмарк метода "Быстрая сортировка"
    /// </summary>
    [Benchmark]
    public double[] QuickSortingBenchmark()
    {
        return _sortingCollection.QuickSorting(_quickSorting);
    }

    #endregion
    
    #region Метод генерации данных

    /// <summary>
    /// Генерация данных для бенчмарков
    /// </summary>
    private void GeneratedData()
    {
        // Данные для 1 бенчмарка
        Random random = new Random();
        _sortingСhoice = new double[10000];
        for (int i = 0; i < 10000; i++)
        {
            _sortingСhoice[i] = random.NextDouble();
        }
        
        // Данные для 2 бенчмарка
        _quickSorting = new double[10000];
        for (int i = 0; i < 10000; i++)
        {
            _quickSorting[i] = random.NextDouble();
        }
    }

    #endregion
}