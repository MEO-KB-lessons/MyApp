// Test application

Console.WriteLine("Hello, WORLD!");


// Реверс строки 

static string ReverseString(string input)
{
    // Способ 1: Использование массива символов
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
    
    // Способ 2: Вручную через цикл
    // string result = "";
    // for (int i = input.Length - 1; i >= 0; i--)
    // {
    //     result += input[i];
    // }
    // return result;
}
    
string input = "Строка для тестирования программы";
Console.WriteLine($"Исходная строка: {input}");
Console.WriteLine($"Перевернутая строка: {ReverseString(input)}");