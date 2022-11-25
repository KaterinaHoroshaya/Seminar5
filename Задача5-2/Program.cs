int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int[] pairs;

FillArrayRandomNumbers(numbers, 1, 9);
WriteArray(numbers);

if (numbers.Length % 2 == 0)
{
    pairs = new int[numbers.Length/2];
}
else
{
    pairs = new int[numbers.Length/2 + 1];
    pairs[pairs.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < numbers.Length / 2; i++)
{
    pairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
WriteArray(pairs);

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
