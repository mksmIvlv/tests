using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class SearchInCollectionBenchmark
{
    #region Поля

    /// <summary>
    /// Класс с методами для бенчмарка
    /// </summary>
    private SearchInCollection _searchInCollection;

    /// <summary>
    /// Коллекция для метода BinarySearch
    /// </summary>
    private double[] _binarySearchArray;

    /// <summary>
    /// Коллекция для метода MaximumNumberInTheArray
    /// </summary>
    private int[] _maximumNumberInTheArray;

    /// <summary>
    /// Коллекция для метода MinimumNumberInTheArray
    /// </summary>
    private int[] _minimumNumberInTheArray;

    /// <summary>
    /// Коллекция для метода AverageValueInTheArray
    /// </summary>
    private int[] _averageValueInTheArray;

    /// <summary>
    /// Коллекция для метода ProfitableClient
    /// </summary>
    private int[][] _profitableClient;

    /// <summary>
    /// Коллекция для метода AvoidJailDueToTaxFraud
    /// </summary>
    private int[][] _avoidJailDueToTaxFraud;
    

    #endregion

    #region Конструктор

    public SearchInCollectionBenchmark()
    {
        _searchInCollection = new SearchInCollection();
        GeneratedData();
    }

    #endregion

    #region Методы бенчмарка
    
    /// <summary>
    /// Бенчмарк метода "Бинарный поиск"
    /// </summary>
    [Benchmark]
    public int BinarySearchBenchmark()
    {
        var item = 1.24;
        
        return _searchInCollection.BinarySearch(_binarySearchArray, item);
    }
    
    /// <summary>
    /// Бенчмарк метода "Нахождение максимального числа в массиве"
    /// </summary>
    [Benchmark]
    public int MaximumNumberInTheArrayBenchmark()
    {
        return _searchInCollection.MaximumNumberInTheArray(_maximumNumberInTheArray);
    }
    
    /// <summary>
    /// Бенчмарк метода "Нахождение минимального числа в массиве"
    /// </summary>
    [Benchmark]
    public int MinimumNumberInTheArrayBenchmark()
    {
        return _searchInCollection.MinimumNumberInTheArray(_minimumNumberInTheArray);
    }
    
    /// <summary>
    /// Бенчмарк метода "Нахождение среднего значения массива"
    /// </summary>
    [Benchmark]
    public double AverageValueInTheArrayBenchmark()
    {
        return _searchInCollection.AverageValueInTheArray(_averageValueInTheArray);
    }
    
    /// <summary>
    /// Бенчмарк метода "Нахождение выгодного заказчика"
    /// </summary>
    [Benchmark]
    public int ProfitableClientBenchmark()
    {
        return _searchInCollection.ProfitableClient(_profitableClient);
    }
    
    /// <summary>
    /// Бенчмарк метода "Проверить массив на уникальные записи."
    /// </summary>
    [Benchmark]
    public int AvoidJailDueToTaxFraudBenchmark()
    {
        return _searchInCollection.AvoidJailDueToTaxFraud(_avoidJailDueToTaxFraud);
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
        _binarySearchArray = new double[10000];
        for (int i = 0; i < 10000; i++)
        {
            _binarySearchArray[i] = random.NextDouble();
        }

        // Данные для 2 бенчмарка
        _maximumNumberInTheArray = new int[10000];
        for (int i = 0; i < 1000; i++)
        {
            _maximumNumberInTheArray[i] = random.Next();
        }

        // Данные для 3 бенчмарка
        _minimumNumberInTheArray = new int[10000];
        for (int i = 0; i < 1000; i++)
        {
            _minimumNumberInTheArray[i] = random.Next();
        }

        // Данные для 4 бенчмарка
        _averageValueInTheArray = new int[10000];
        for (int i = 0; i < 1000; i++)
        {
            _averageValueInTheArray[i] = random.Next();
        }

        // Данные для 5 бенчмарка
        _profitableClient = new int[100][];
        for (int i = 0; i < _profitableClient.Length; i++)
        {
            _profitableClient[i] = new int[1000];
            for (int j = 0; j < _profitableClient[i].Length; j++)
            {
                _profitableClient[i][j] = random.Next();
            }
        }

        // Данные для 6 бенчмарка
        _avoidJailDueToTaxFraud = new int[100][];
        for (int i = 0; i < _avoidJailDueToTaxFraud.Length; i++)
        {
            _avoidJailDueToTaxFraud[i] = new int[100];
            for (int j = 0; j < _avoidJailDueToTaxFraud[i].Length; j++)
            {
                _avoidJailDueToTaxFraud[i][j] = random.Next();
            }
        }
    }

    #endregion
}