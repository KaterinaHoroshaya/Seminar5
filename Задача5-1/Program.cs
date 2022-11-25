Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 10);
WriteArray(numbers);

int[] result = new int[size / 2];

if (size % 2 == 0)
{
    for (int i = 0, g = size - 1; i < size / 2; i++, g--)
    {
        result[i] = numbers[i] * numbers[g];
    }
}
else
{
    result = new int[size / 2 + 1];
    for (int i = 0, g = size - 1; i < size / 2; i++, g--)
    {
        result[i] = numbers[i] * numbers[g];
    }
    result[size / 2] = numbers[size / 2];
}
WriteArray(result);



void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
