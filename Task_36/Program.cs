// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
int[] nums = new int[length];
Random numRand = new Random();

for (int i = 0; i < length; i++)
{
    nums[i] = numRand.Next(-100, 100);
    Console.Write(nums[i] + " ");
}

int sum = 0;
for (int i = 0; i < length; i++)
{
    if (i % 2 > 0) sum += nums[i];
}

Console.WriteLine(" ");
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sum}");