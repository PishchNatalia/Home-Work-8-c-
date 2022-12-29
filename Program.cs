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
/*
Сonsole.WriteLine("Введите размер квадратного массива: ");
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
    
*/
// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int [,] array = new int[rows,columns];
int [,] secondArray = new int[rows,columns];
int [,] resutArray = new int[rows,columns];
FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);
Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Нельзя перемножить");
    return;
}
for (int i = 0; i < array.GetLength(0);i++)
{
    for ( int j = 0;j < secondArray.GetLength(1);j++)
    {
        resutArray[i,j] = 0;
        for (int k = 0;k < array.GetLength(1);k++)
        {
            resultArray[i,j] += array[i,k] * secondArray[k,j];
        }
    }
}
PrintArray2D(resultArray);


int ReadInt(string message)
{
    Console.Write(message);
    return
    Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array) //Заполняем массив рандомными числами от 1 до 9
{
    for (int i = 0;i < array.GetLength(0);i++)
    {
        for (int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray2D(int[,] array) // Выводим в терминал двумерный массив.
{
    for (int i = 0;i < array.GetLength(0);i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]}");
        }
            Сonsole.WriteLine();
    }
    
}
*/
// Задача 4.Напишите программу, которая заполнит спирально массив 4 на 4.


int n = 4;
int[,]sqareMatrix = new int[n,n];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i,j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
    else
    i--;
}

WriteArray(sqareMatrix);
void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0);i++)
    {
        for (int j = 0;j < array.GetLength(1);j++)
        {
            if (array[i,j] / 10 <= 0)
            Console.Write($"{array[i,j]} ");

            else Console.Write($"{array[i,j]}");
        }
        Сonsole.WriteLine();
    }

}























int rows = ReadInt("Введите количество строк: ");
            int columns = ReadInt("Введите количество столбцов: ");
            int[,] array = new int[rows, columns];
            int[,] secondArray = new int[rows, columns];
            int[,] resultArray = new int[rows, columns];
            
            FillArrayRandom(array);
            PrintArray2D(array);
            
            Console.WriteLine();
            
            FillArrayRandom(secondArray);
            PrintArray2D(secondArray);
            
            Console.WriteLine();
            
            if (array.GetLength(0) != secondArray.GetLength(1))
            {
                Console.WriteLine(" Нельзя перемножить ");
                return;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    resultArray[i, j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                       resultArray[i, j] += array[i, k] * secondArray[k, j];
                    }
                }
            }
            
            PrintArray2D(resultArray);
            
            
            
            // Функция ввода
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            // Функция заполнения массива рандомными числами от 1 до 9
            void FillArrayRandom(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                    }
                }
            }
            
            // Функция вывода двумерного массива в терминал 
            void PrintArray2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }            
        
    


