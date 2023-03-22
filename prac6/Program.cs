Console.WriteLine("Выберите на какую оценку вы хотите посмотреть (3-4):"); int ocenka = Convert.ToInt32(Console.ReadLine());
if (ocenka == 3)
{
    Console.WriteLine("Введите длину массива:"); int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    Console.WriteLine($"Введите {n} значений:");
    for (int i = 0; i < n; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    int umn = array[0];
    int sum = array[0];
    int max = int.MinValue;
    int min = int.MaxValue;
    double mid = 0;

    Console.WriteLine("Выберите способ: \r\n1 - Функции \r\n2 - Цикл"); int sposob = Convert.ToInt32(Console.ReadLine());

    if (sposob == 1)
    {
        for (int i = 1; i < n; i++) umn *= array[i];
        Console.WriteLine($"Максимальное число: {array.Max()}\r\nМинимальное число:{array.Min()} \r\nСреднее число: {array.Average()}\r\nКоличество элементов: {array.Count()} \r\nСумма: {array.Sum()} \r\nПроизведение: {umn}");
    }
    if (sposob == 2)
    {
        for (int i = 1; i < n; i++) umn *= array[i];
        for (int i = 1; i < n; i++) sum += array[i];
        for (int i = 0; i < n; i++)
            if (array[i] > max) max = array[i];
        for (int i = 0; i < n; i++)
            if (array[i] < min) min = array[i];
        mid = sum / n;

        Console.WriteLine($"Максимальное число: {max} \r\nМинимальное число:{min} \r\nСреднее число:{mid} \r\nКоличество элементов: {n} \r\nСумма: {sum} \r\nПроизведение: {umn}");
    }
} 