/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.WriteLine("введите количество строк и столбцов");
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
Console.WriteLine("Введите позицию элемента");
int element_x = Convert.ToInt32(Console.ReadLine());
int element_y = Convert.ToInt32(Console.ReadLine());

if(element_x > row_count || element_y > coiumn_count)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(result[element_y - 1][element_x - 1]);
}

