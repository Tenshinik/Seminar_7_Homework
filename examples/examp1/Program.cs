/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.WriteLine("Задайте количество строк и столбцов в матрице");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Random random = new();
double GenerateRandomNumber()
{
   //Int64 temp = (Int64)int.MaxValue -(Int64)int.MinValue;
    const Int64 min_value = -100;
    const Int64 max_value = 100;
    return min_value + (max_value - min_value) * random.NextDouble(); 
}
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        Console.Write(string.Format("{0:0.0}", GenerateRandomNumber()));
        Console.Write(" ");
    }
    Console.WriteLine();
}
