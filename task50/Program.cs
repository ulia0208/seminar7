// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

void InputMatrix (int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i, j]=new Random().Next(-10, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    } 
}

Console.Clear();
Console.Write("Введите количество строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int m =Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];

InputMatrix(matrix);

Console.Write("Введите номер строки ");
int l =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца ");
int k=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(matrix[l-1,k-1]);