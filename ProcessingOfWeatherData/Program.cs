using System;
using System.Linq;

class WeatherDataProcessor
{
    static void Main()
    {
        Console.WriteLine("Введите температуры за несколько дней (через пробел):");
        double[] temperatures = Console.ReadLine().Split().Select(double.Parse).ToArray();

        double averageTemperature = temperatures.Average();
        double maxTemperature = temperatures.Max();
        double minTemperature = temperatures.Min();

        Console.WriteLine($"Средняя температура: {averageTemperature}");
        Console.WriteLine($"Максимальная температура: {maxTemperature}");
        Console.WriteLine($"Минимальная температура: {minTemperature}");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadLine();
    }
}
