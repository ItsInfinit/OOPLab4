using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfOOPLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:\n");

            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter array element[{i}]: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            double min = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"\nMinimum element of the array: {min}");

            double sum = 0;
            int firstPositiveIndex = -1;
            int secondPositiveIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    if (firstPositiveIndex == -1)
                    {
                        firstPositiveIndex = i;
                    }
                    else if (secondPositiveIndex == -1)
                    {
                        secondPositiveIndex = i;
                        break;
                    }
                }
            }

            if (firstPositiveIndex != -1 && secondPositiveIndex != -1)
            {
                int startIndex = Math.Min(firstPositiveIndex, secondPositiveIndex);
                int endIndex = Math.Max(firstPositiveIndex, secondPositiveIndex);

                for (int i = startIndex + 1; i < endIndex; i++)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine($"Sum of elements between the first and second positive elements: {sum}");

            double[] transformedArray = new double[n];
            int zeroIndex = 0;
            int nonZeroIndex = n - 1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    transformedArray[zeroIndex] = array[i];
                    zeroIndex++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] != 0)
                {
                    transformedArray[nonZeroIndex] = array[i];
                    nonZeroIndex--;
                }
            }

            Console.WriteLine("Transformed array:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(transformedArray[i]);
            }

            Console.WriteLine("\nPress any key to proceed to Task 2...");
            Console.ReadKey();


            Console.WriteLine("Task 2:\n");

            int[,] matrix = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"Enter element [{i}, {j}] of the matrix: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int lowerRight = matrix[1, 1];
            int lowerLeft = matrix[1, 0];
            int upperRight = matrix[0, 1];
            int upperLeft = matrix[0, 0];

            Console.WriteLine("2D array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }

            if (lowerRight < lowerLeft)
            {
                Console.WriteLine("\nElement in the lower right corner is smaller than the element in the lower left corner.");
            }
            else if (lowerLeft < lowerRight)
            {
                Console.WriteLine("\nElement in the lower left corner is smaller than the element in the lower right corner.");
            }
            else
            {
                Console.WriteLine("\nElements in the lower right and lower left corners are equal.");
            }

            if (upperRight < lowerLeft)
            {
                Console.WriteLine("\nElement in the upper right corner is smaller than the element in the lower left corner.");
            }
            else if (lowerLeft < upperRight)
            {
                Console.WriteLine("\nElement in the lower left corner is smaller than the element in the upper right corner.");
            }
            else
            {
                Console.WriteLine("\nElements in the upper right and lower left corners are equal.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
