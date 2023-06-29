double[] FillArray()
{
    double[] array = new double[5];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }
    return array;
}

void Sum(double[] array, out double max, out double min)
{
    max = array[0];
    min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");

}

double[] array = FillArray();
PrintArray(array);
Sum(array, out double maximal, out double minimal);

Console.WriteLine($"Минимальное число: {minimal}");
Console.WriteLine($"Минимальное число: {maximal}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {maximal - minimal}");

