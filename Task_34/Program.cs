// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] nums = new int[length];
Random numRand = new Random();

for (int i = 0; i < length; i++)
{
    nums[i] = numRand.Next(100, 1000);
    Console.Write(nums[i] + " ");
}

int count = 0;
for (int i = 0; i < length; i++)
{
    if (nums[i] % 2 == 0) count++;
}

Console.WriteLine(" ");
Console.WriteLine($"Количество чётных чисел в массиве - {count}");

