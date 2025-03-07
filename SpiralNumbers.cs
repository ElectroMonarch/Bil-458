/*

        Yağız Akın BAŞTOPÇU
            22393532

*/

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int top = 0, bottom = n - 1, left = 0, right = n - 1;
        int num = 1;

        while (num <= n * n)
        {
            // Fill top row (left to right)
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;
            top++;

            // Fill right column (top to bottom)
            for (int i = top; i <= bottom; i++)
                matrix[i, right] = num++;
            right--;

            // Fill bottom row (right to left)
            for (int i = right; i >= left; i--)
                matrix[bottom, i] = num++;
            bottom--;

            // Fill left column (bottom to top)
            for (int i = bottom; i >= top; i--)
                matrix[i, left] = num++;
            left++;
        }

        // Print the spiral matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}
