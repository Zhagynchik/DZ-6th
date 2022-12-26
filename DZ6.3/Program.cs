//* Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.  */


int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-99,99);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int[] NewArray(int[] array)
{
    int[] result = new int[array.Length];
    for (int i=0; i<array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

int []array = InitArray(10);
PrintArray(array);
int[]result = NewArray(array);

PrintArray(result);