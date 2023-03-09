// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

System.Console.WriteLine("Первая матрица:");
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
var firstMatrix = GetMatrix(numRows, numColumns);


System.Console.WriteLine("Вторая матрица:");
numRows = SetNumber("Rows");
numColumns = SetNumber("Columns");
var secondMatrix = GetMatrix(numRows, numColumns);

Print(firstMatrix);
System.Console.WriteLine("X");
Print(secondMatrix);

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)){
    System.Console.WriteLine("Нельзя перемножить эти матрицы!!");
}
else {
    System.Console.WriteLine("=");
    Print(multi(firstMatrix, secondMatrix));
}
int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
    


    void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                Console.Write(matrix[i, k] + " ");
            }
            Console.WriteLine();
        }
    }

    int[,] GetMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int k = 0; k < columns; k++)
            {
                matrix[i, k] = new Random().Next(1, 10);
            }
        }
        return matrix;
    }

    int[,] multi(int[,] matrixFirst, int[,] matrixSecond) 
{
    int[,] result = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];

    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int l = 0; l < matrixSecond.GetLength(1); l++)
        {
            for (int k = 0; k < matrixSecond.GetLength(0); k++)
            {
                result[i, l] += matrixFirst[i, k] * matrixSecond[k, l];
            }
        }
    }
    return result;
}