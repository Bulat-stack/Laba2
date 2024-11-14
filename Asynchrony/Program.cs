using System;
using System.Threading.Tasks;

public class AsyncExample
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Начало работы.");

        // Асинхронный вызов функции, выполняющей арифметические действия
        Task<int> longCalculationTask = LongCalculationAsync(10000000, 10000000);

        // Продолжение выполнения кода, пока функция выполняется
        Console.WriteLine("Продолжение выполнения программы.");
        Console.WriteLine("Выполнение других задач...");

        // Ожидание завершения асинхронной операции
        int result = await longCalculationTask;

        Console.WriteLine($"Результат операции: {result}");

        Console.WriteLine("Завершение работы.");
    }

    // Асинхронная функция, имитирующая долгую арифметическую операцию
    private static async Task<int> LongCalculationAsync(int num1, int num2)
    {
        Console.WriteLine("Начало асинхронной операции...");

        // Имитация длительной работы (здесь мы умножаем два больших числа)
        await Task.Delay(3000); // Пауза в 3 секунды

        Console.WriteLine("Асинхронная операция завершена.");

        return num1 * num2;
    }
}