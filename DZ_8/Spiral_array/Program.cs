


int rows = 4;
int columns = 4;

int[,] GetArray1(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m-2; i++)
    {
        for (int j = 0; j < n-1; j++)
        {
            result[0,0]=1;
            result[i, j+1] = result[i, j]+1;
        }

    }return result;
    
    
}


int[,] GetArray2(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m-1; i++)
    {
        for (int j = 3; j < n; j++)
        {
            result[0, 3] = 4;
            result[i+1, j] = result[i, j]+1;
        }
        
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        
        }
        
        Console.WriteLine();
    }
    
}





int[,] array = GetArray1(rows, columns, 1, 9);

int[,] array2 = GetArray2(rows, columns, 1, 9);

PrintArray(array);
PrintArray(array2);