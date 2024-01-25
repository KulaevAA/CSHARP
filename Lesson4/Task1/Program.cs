int [,] CreateArray (int Stroki, int Stolbci)
{
   Random rnd = new Random();
    int [,] matrix = new int [Stroki, Stolbci];
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
           matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}

void ShowArray (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
           Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

}

int [,] arr = CreateArray(3,5);
ShowArray(arr);
