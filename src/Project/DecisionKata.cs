using System.Text.RegularExpressions;

namespace Project;

public class DecisionKata
{
    /// <summary>
    /// Создание номера телефона из входящего массива
    /// </summary>
    /// <param name="numbers">Массив цифр</param>
    /// <returns>Строка</returns>
    public string CreatePhoneNumber(int[] numbers)
    {
        string numberPhone = "(";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 3)
            {
                numberPhone += ") ";
            }

            if (i == 6)
            {
                numberPhone += "-";
            }
            numberPhone += numbers[i];
        }
            
        return numberPhone;
        
        // Решение с помощью LinQ  
        //return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
    }
    
    /// <summary>
    /// Вытащить из массива только цифры
    /// </summary>
    /// <param name="listOfItems">Массив объектов</param>
    /// <returns>Массив цифр</returns>
    public ICollection<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> returnCollection = new List<int>();
        for (int i = 0; i < listOfItems.Count; i++)
        {
            if (listOfItems[i].GetType() == typeof(int))
            {
                returnCollection.Add((int)listOfItems[i]);
            }
        }

        return returnCollection;
        
        // Решение с помощью LinQ    
        //return listOfItems.OfType<int>();
    }

    /// <summary>
    /// Из строки нужно каждые две буквы объединить и положить в массив "asdfg" => 'as' 'df' 'g_'
    /// </summary>
    /// <param name="str">Строка</param>
    /// <returns>Массив строк, состоящих из двух букв</returns>
    public string[] Solution(string str)
    {
        // В строку для добавления в новый массив сразу записываем первый символ из входящей строки
        var strToAdd = str[0].ToString();
        
        // Счетчик для итерирования по результирующему массиву
        var countIndex = 0;
        
        // Флаг для добавления символов в конец массива
        var addEnd = false;
        // Размер результирующего массива
        
        var sizeResultArray = 0;
        
        // Верно установить размер массива
        if (str.Length % 2 == 0)
            sizeResultArray = str.Length / 2;
        else
        {
            sizeResultArray = str.Length / 2 + 1;
            addEnd = true;
        }
        
        // Создать результирующий массив
        string[] returnResult = new string[sizeResultArray];
        
        for (int i = 1; i < str.Length; i++)
        {
            strToAdd += str[i];
            if (i % 2 != 0)
            {
                returnResult[countIndex] = strToAdd;
                strToAdd = String.Empty;
                countIndex++;
            }
        }
        
        if (addEnd)
        {
            returnResult[countIndex] += $"{strToAdd}_";
        }
        
        return returnResult;
    }

    /// <summary>
    /// Проверка на валидность IP адреса
    /// </summary>
    /// <param name="ipAddress">IP адрес</param>
    /// <returns>True - если валидный, иначе false</returns>
    public bool IsValidIp(string ipAddress)
    {
        var ip = new Regex(@"^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");

        if (ip.IsMatch(ipAddress))
            return true;
        else
            return false;
    }
}





