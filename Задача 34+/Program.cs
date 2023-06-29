

int[] FillArray()
{
    int[] array = new int[5];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 999);
    } return array;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void FindCount(int[] array, out int count)

{
    count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
}

int[] array = FillArray();
PrintArray(array);
FindCount(array, out int well);

System.Console.WriteLine($"Количество четных чисел : {well}");