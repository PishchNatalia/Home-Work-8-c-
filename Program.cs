// Домашняя работа 8.
// Задача 1.Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m,n];

FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения ");
PrintArray(numbers);
for (int i = 0; i < numbers.GetLength(0);i++)
{
    for (int j = 0;j < numbers.GetLength(1) -1;j++)
    {
        for (int k = 0;k < numbers.GetLength(1) -1;k++)
        {
            if (numbers[i,k] < numbers [i,k+1])
            {
                int temp = 0;
                temp = numbers[i,k];
                numbers[i,k] = numbers[i,k+1];
                numbers[i,k+1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0;i < array.GetLength(0);i++)
    {
        for (int j = 0;j < array.GetLength(1) -1;j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0;i < array.GetLength(0);i++)
    {
    Console.Write("[ ");
    for (int j = 0;j < array.GetLength(1) -1;j++)
        {
        Console.Write(array[i,j] + "  ");
        }
        Console.Write("]");
        Console.Write("");
    }    
}
*/
// Задача 2.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.WriteLine("Введите размер квадратного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [m,m];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0;i < numbers.GetLength(0);i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i,j];
    }
     if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
}  

Console.WriteLine("Строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой элементов равной: " + (minsum));

    void FillArrayRandomNumbers ( int[,] array)
    {

      for (int i = 0; i < array.GetLength(0);i++) 
      {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
      } 

    }
    void PrintArray(int[,] array)
    {
        for (int i = 0;i < array.GetLength(0);i++) 
        {
            Console.Write(" [ ");
            for (int j = 0;j < array.GetLength(1);j++)
            {
                Console.Write(array[i,j] + " ");
            }
            Console.Write("]");
            Console.WriteLine(" ");
        }
    }
    
