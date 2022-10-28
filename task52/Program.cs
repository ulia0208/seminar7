// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.




void InputMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for (int j=0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j]=new Random().Next(-10,10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int m =Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n,m];
InputMatrix(matrix);

Console.WriteLine("Среднее арифметическое ");

void SumColumn (int[,] matrix)
{
    float[] sum = new float[m];
    float [] middle=new float[m];
    for (int i=0; i<matrix.GetLength(1);i++)
    {
        for(int j=0; j<matrix.GetLength(0); j++)
        {
            sum[i]+= matrix[j,i];
        }
       // Console.Write($"{sum[i]} \t");
        middle[i]=sum[i]/n;
        Console.Write($"{Math.Round(middle[i]*1000)/1000} \t");
        
    }
    Console.WriteLine();
    
}

SumColumn(matrix);


