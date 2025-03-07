/*

        Yağız Akın BAŞTOPÇU
            22393532

*/

import java.util.Scanner;

public class SpiralMatrix
{
    public static void main(String[] args)
    {
        Scanner keyboard = new Scanner(System.in);
        System.out.print("Enter the size of the matrix: ");
        int n = keyboard.nextInt();
        keyboard.close();

        int[][] matrix = new int[n][n];
        int value = 1;
        int top = 0, bottom = n - 1, left = 0, right = n - 1;

        while (value <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top][i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i][right] = value++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom][i] = value++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i][left] = value++;
            }
            left++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.out.printf("%4d", matrix[i][j]);
            }
            System.out.println();
        }
    }
}
