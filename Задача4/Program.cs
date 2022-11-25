/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int [] numbers = new int [12];
int count =0;
for (int i=0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0,1000);
    Console.Write(numbers[i]+" ");
}
Console.WriteLine();
for (int j=0; j<numbers.Length; j++)
{
    if (numbers[j] >9 && numbers[j]<100)
    {
        count++;
    }
}
Console.WriteLine($"Количество найденных элементов: {count}");