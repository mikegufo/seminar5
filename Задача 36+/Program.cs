//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0

int[] FillArray()
{
    int[] array = new int[5];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(10, 99);
    }
    return array;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");

}

void Sum(int[] array, out int sum)
{
    sum = 0;
    for (int i = 0; i < array.Length; i += 2)
        sum = sum + array[i];

}

int[] array = FillArray();
PrintArray(array);
Sum(array, out int well);

Console.WriteLine($"Сумма элементов cтоящих на нечётных позициях = {well}");
