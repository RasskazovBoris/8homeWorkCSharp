// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int sizeOfX = SetNumber("размер X: ");
int sizeOfY = SetNumber("размер Y: ");
int sizeOfZ = SetNumber("размер Z: ");

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
if (sizeOfX + sizeOfY + sizeOfZ > 20) System.Console.WriteLine("Много чисел, сейчас процессор сгорит");
else
{
    int[,,] matrix = tripleMatrix(sizeOfX, sizeOfY, sizeOfZ);
    PrintTripleMatrix(matrix);

    void order(int[] number)
    {
        int length = number.Length;

        for (int i = 0; i < length; i++)
        {
            number[i] = i + 10;
        }
        return;
    }

    int[] mix(int[] arr)
    {
        Random randomNumber = new Random();

        for (int i = arr.Length - 1; i >= 1; i--)
        {
            int l = randomNumber.Next(i + 1);

            int temp = arr[l];
            arr[l] = arr[i];
            arr[i] = temp;
        }
        return arr;
    }

    int[,,] tripleMatrix(int valueOfX, int valueOfY, int valueOfZ)
    {
        int[,,] matrix = new int[valueOfX, valueOfY, valueOfZ];

        int[] array = new int[990];
        order(array);
        mix(array);

        for (int i = 0; i < valueOfX * valueOfY * valueOfZ;)
        {
            for (int l = 0; l < valueOfX; l++)
            {
                for (int k = 0; k < valueOfY; k++)
                {
                    for (int j = 0; j < valueOfZ; j++)
                    {
                        matrix[l, k, j] = array[i];
                        i++;
                    }

                }
            }
        }
        return matrix;
    }

    void PrintTripleMatrix(int[,,] matrix)
    {
        for (int l = 0; l < matrix.GetLength(0); l++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                for (int j = 0; j < matrix.GetLength(2); j++)
                {
                    System.Console.Write($"{matrix[l, k, j]} ({l}, {k}, {j}) ");
                }
                System.Console.WriteLine();
            }
        }
    }
}