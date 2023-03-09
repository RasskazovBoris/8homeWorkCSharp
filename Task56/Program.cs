// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

if (numRows == numColumns)
{
    System.Console.WriteLine("Пожалуйста, введите прямоугольный массив");

}
else
{

    var matrix = GetMatrix(numRows, numColumns);
    Print(matrix);
    System.Console.WriteLine($"В строчке №{MinRowSum(matrix) + 1} минимальная сумма чисел!");

    void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            System.Console.Write($"Строчка №{i + 1}: ");
            for (int l = 0; l < matrix.GetLength(1); l++)
            {
                Console.Write(matrix[i, l] + " ");
            }
            Console.WriteLine();
        }
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

    int MinRowSum(int[,] matrix)
    {
        int row = 0;
        int? min = null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int l = 0; l < matrix.GetLength(1); l++)
            {
                sum = sum + matrix[i, l];
            }
            if (min == null) min = sum;
            else if (sum < min)
            {
                min = sum;
                row = i;
            }

        }
        return row;
    }
}