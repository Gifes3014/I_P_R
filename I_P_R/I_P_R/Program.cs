int[] GetArray(int m, int min, int max)
{
    int[] result = new int[m];
    for (int i = 0; i < m; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}
int[] GetArray_2(int[] arr)
{
    int n = 0;
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        k += Convert.ToString(arr[i]).Length <= 3 ? 1 : 0;
    }
    int[] result = new int[k];
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if (Convert.ToString(arr[j]).Length <= 3)
        {
            result[n] = arr[j];
            n++;
        }
    }
    return result;
}
void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i] + " "}");
    }
}
Console.Write("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = GetArray(number, 0, 10000);
int[] array_2 = GetArray_2(array);
PrintArray(array);
Console.WriteLine();
PrintArray(array_2);