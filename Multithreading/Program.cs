using System;
using System.Threading;
using System.Threading.Tasks;

public class MultiThreadingExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Начало работы.");

        // Создание двух задач
        Task task1 = Task.Run(() => LongOperation("Задача 1"));
        Task task2 = Task.Run(() => LongOperation("Задача 2"));

        // Ожидание завершения обеих задач
        Task.WaitAll(task1, task2);

        Console.WriteLine("Завершение работы.");
    }

    // Функция, имитирующая длительную операцию
    private static void LongOperation(string taskName)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{taskName}: Итерация {i + 1}");
            Thread.Sleep(1000); // Задержка в 1 секунду
        }
    }
}