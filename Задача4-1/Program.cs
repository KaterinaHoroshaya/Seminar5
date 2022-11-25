int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int minSegment = 10;
int maxSegment = 99;
int count = 0;

FillArrayRandomNumbers(numbers, 1, 120);
WriteArray(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < minSegment || numbers[i] > maxSegment)
        continue;

    count++;
}
Console.WriteLine(count);


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






