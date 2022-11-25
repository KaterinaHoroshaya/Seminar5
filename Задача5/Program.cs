/*  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] numbers = new int[4];
int lev = 0;
int prav = numbers.Length-1;
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 10);
    Console.Write(numbers[i]+" ");
}
Console.WriteLine();
if (numbers.Length%2==0)
    while (lev<(numbers.Length)/2)
    {
        Console.Write(numbers[lev]*numbers[prav]+" ");
        lev++;
        prav--;
    }
else
{
    while (lev<=(numbers.Length)/2)
    {
        if (lev==prav)
        {
            Console.Write(numbers[lev]);
        }
        else
        {
            Console.Write(numbers[lev]*numbers[prav]+" ");
        }
        lev++;
        prav--;
    }  
}

