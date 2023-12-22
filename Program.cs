using System;

namespace timmaxtrongmatrix2chieu
{
    class timmaxtrongmatrix2chieu
    {
        public static void Main()
        {
            int i; int j; int row; int column; 
            Console.WriteLine("Enter size of a 2D square matrix under 100 elements: ");
            do {
            Console.WriteLine("Enter length of row - under 100 elements: ");
            row = Convert.ToInt32(Console.ReadLine());
            if (row>100) Console.WriteLine("The row length should not exceed 100");
            }
            while (row > 100);
            column = row;

            int[,] matrix = new int[row, column];

            Console.WriteLine("Enter elements of the matrix: ");
            Console.WriteLine("Enter " + matrix.GetLength(0) + " rows and " + matrix.GetLength(1) + " columns: ");
            for (i = 0; i < matrix.GetLength(0); i++)
            {
            for (j = 0; j < matrix.GetLength(1); j++) 
                {
                Console.WriteLine("matrix element [" + i + "," + j + "]");
                matrix[i,j] = Int32.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("The maxtrix that you have entered is: ");
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int p = 0; p < matrix.GetLength(1); p++)
                {
                    Console.Write(matrix[k, p] + " ");
                }
                Console.WriteLine();
            }

            int total = 0;
            for (i = 0; i < matrix.GetLength(0); i++)
            {
            for (j = 0; j < matrix.GetLength(1); j++) 
            {
                if (i==j) {total += matrix[i,j];}
            }
            }
            Console.WriteLine("The total of elements on the main diagonal of the matrix is " + total );   
    }
    }
}