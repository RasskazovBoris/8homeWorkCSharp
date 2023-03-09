// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.


int numRows = SetNumber("Rows");

int numColumns = SetNumber("Columns");


var matrix = GetMatrix(numRows, numColumns);
Print(matrix);
System.Console.WriteLine("__________");
sortedMatrix(matrix);
Print(matrix);


int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write(matrix[i, l] + " ");
        }
        Console.WriteLine();
    }
}

void sortedMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int l = 0; l < matrix.GetLength(1)-1; l++)
            {
                if (matrix[i,l] < matrix [i,l+1])
                {
                    int temp = matrix [i,l+1];
                    matrix [i,l+1] = matrix[i,l];
                    matrix[i,l] = temp;
                }
                
            }
            
        }
        
    } 
    
}

