/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Задайте массив из целых чисел");
int coiumn_count = Convert.ToInt32(Console.ReadLine());
int row_count = Convert.ToInt32(Console.ReadLine());
Random random = new();
int GenerateRandomNumber()
{
   //Int64 temp = (Int64)int.MaxValue -(Int64)int.MinValue;
    const Int64 min_value = -100;
    const Int64 max_value = 100;
    return (int)(min_value + (max_value - min_value) * random.NextDouble()); 
}

List<List<int>> result = new();

for (int i = 0; i < row_count; i++)
{
    result.Add(new());
    for (int k = 0; k < coiumn_count; k++)
    {
        int randomNumber = GenerateRandomNumber();
        result[i].Add(randomNumber);

        Console.Write(randomNumber);
        Console.Write(" ");
    }
    Console.WriteLine();
}

for(int k = 0; k < coiumn_count; k++)
{
    double sum = 0;
    for(int i = 0; i < row_count; i++)
    {
        sum += result[i][k];
    }
    Console.Write(sum / row_count);
    Console.Write("; ");
}