using BenchmarkDotNet.Attributes;
using Project;

namespace ProjectBenchmark;

public class DecisionKataBenchmark
{
    #region Поле

    private DecisionKata _decisionKata;

    #endregion

    #region Конструктор

    public DecisionKataBenchmark()
    {
        _decisionKata = new DecisionKata();
    }

    #endregion

    #region Методы

    [Benchmark]
    public void CreatePhoneNumberBenchmark()
    {
        var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        _decisionKata.CreatePhoneNumber(array);
    }
    
    [Benchmark]
    public ICollection<int> GetIntegersFromListBenchmark()
    {
        var collection = new List<object> { 1, 2, "q", -90, "e", 6, "rrr", 8.7, "t", 0 };

        return _decisionKata.GetIntegersFromList(collection);
    }

    [Benchmark]
    public string[] Solution()
    {
        var str = "магазин";

        return _decisionKata.Solution(str);
    }

    [Benchmark]
    public bool IsValidIp()
    {
        var ip = "12.34.56.78sf";

        return _decisionKata.IsValidIp(ip);
    }

    #endregion
}