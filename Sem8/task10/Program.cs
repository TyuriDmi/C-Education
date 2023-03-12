int [,] Spiral (int lines, int columns ) {
    int[,] array = new int[lines, columns];
    int i = 0;
    int j = 0;
    int dim = 1;
    array[i,j] = dim;
    while(dim<lines*columns) {
        Console.Write(array[i,j]);
        if (array[i, j+1] == 0 || j<columns-1) {
            array[i, j+1] = dim+1;
            j++;
            dim++;
        }
        else if (array[i+1, j] == 0 || i<lines-1) {
            array[i+1, j] = dim+1;
            i++;
            dim++;
        }
        else if (array[i, j-1] == 0 || j>=0) {
            array[i, j-1] = dim+1;
            j--;
            dim++;
        }
        else if (array[i-1, j] == 0 || i>=0) {
            array[i-1, j] = dim+1;
            i--;
            dim++;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.Write($"{array[i, array.GetLength(1)-1]}]");
        Console.WriteLine();
    }
}

PrintArray(Spiral(4,4));

    