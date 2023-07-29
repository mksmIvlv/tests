using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class DecisionKataBenchmark
{
    #region Поля

    /// <summary>
    /// Класс с методами для бенчмарка
    /// </summary>
    private DecisionKata _decisionKata;

    /// <summary>
    /// Коллекция для метода GetIntegersFromList
    /// </summary>
    private List<object> _getIntegersFromListCollection;

    /// <summary>
    /// Строка для метода Solution
    /// </summary>
    private string _solutionString;

    #endregion

    #region Конструктор

    public DecisionKataBenchmark()
    {
        _decisionKata = new DecisionKata();
        GeneratedData();
    }

    #endregion

    #region Методы бенчмарка

    /// <summary>
    /// Бенчмарк метода "Создание номера телефона из входящего массива"
    /// </summary>
    [Benchmark]
    public void CreatePhoneNumberBenchmark()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        _decisionKata.CreatePhoneNumber(array);
    }
    
    /// <summary>
    /// Бенчмарк метода "Вытащить из массива только цифры"
    /// </summary>
    [Benchmark]
    public ICollection<int> GetIntegersFromListBenchmark()
    {
        return _decisionKata.GetIntegersFromList(_getIntegersFromListCollection);
    }

    /// <summary>
    /// Бенчмарк метода "Из строки нужно каждые две буквы объединить и положить в массив "asdfg" => 'as' 'df' 'g_'"
    /// </summary>
    [Benchmark]
    public string[] SolutionBenchmark()
    {
        return _decisionKata.Solution(_solutionString);
    }

    /// <summary>
    /// Бенчмарк метода "Проверка на валидность IP адреса"
    /// </summary>
    [Benchmark]
    public bool IsValidIpBenchmark()
    {
        var ip = "12.34.56.78sf";

        return _decisionKata.IsValidIp(ip);
    }

    #endregion
    
    #region Метод генерации данных

    /// <summary>
    /// Генерация данных для бенчмарков
    /// </summary>
    private void GeneratedData()
    {
        // Данные для GetIntegersFromListBenchmark
        _getIntegersFromListCollection = new List<object>();
        for (int i = 0; i < 10000; i++)
        {
            _getIntegersFromListCollection.Add(i);
            if (i % 2 == 0)
                _getIntegersFromListCollection.Add(i.ToString());
        }
        
        // Данные для SolutionBenchmark
        for (int i = 0; i < 100; i++)
        {
            _solutionString += i.ToString();
        }
    }

    #endregion
}