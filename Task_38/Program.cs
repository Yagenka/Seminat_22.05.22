// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76


Console.Write("Задайте длину массива: ");
int length = int.Parse(Console.ReadLine());
double[] nums = new double[length];
Random numRand = new Random();

for (int i = 0; i < length; i++)
{
    nums[i] = double.Parse(Console.ReadLine());
}

double max = nums[0];
double min = nums[0];
double delta = 0;

for (int i = 0; i < length; i++)
{
    if (max < nums[i])
    {
        max = nums[i];
    }
    if (min > nums[i])
    {
        min = nums[i];
    }
    delta = max - min;
}

Console.Write($"Разница между максимальным и минимальным  элементами в массиве равна {delta}");