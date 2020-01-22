using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    public class Solutions
    {
        /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */


        public static int diagonalDifference(List<List<int>> arr)
        {
            int length = arr.Count;
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            for (int i = 0; i < length; i++)
            {
                firstDiagonalSum += arr[i][i];
                secondDiagonalSum += arr[i][length - 1 - i];
            }


            return Math.Abs(firstDiagonalSum - secondDiagonalSum);
        }


        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int length = arr.Length;
            int numOfPositive = 0;
            int numOfNegative = 0;
            int numOfZero = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    numOfPositive += 1;
                }
                else if (arr[i] < 0)
                {
                    numOfNegative += 1;
                }
                else
                {
                    numOfZero += 1;
                }
            }

            Console.WriteLine((double)numOfPositive / (double)length);
            Console.WriteLine((double)numOfNegative / (double)length);
            Console.WriteLine((double)numOfZero / (double)length);
        }


        // Complete the staircase function below.
        static void staircase(int n)
        {

            for (int i = 0; i < n; i++)
            {
                int numOfHashes = i + 1;
                int numOfSpaces = n - numOfHashes;

                // print spaces
                for (int j = 0; j < numOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                // print hashes
                for (int j = 0; j < numOfHashes; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }



        public static List<List<int>> FindBeforeMatrix(List<List<int>> after)
        {
            // Write your code here
            List<List<int>> result = new List<List<int>>();
            result[0][0] = after[0][0];

            for(int i = 0; i < after.Count(); i++)
            {
                for(int j = 1; j < after[i].Count(); j++)
                {
                    result[i][j] = CalculateValue(after[i][j], after, i, j);
                }              
            }

            return result;

        }

        public static int CalculateValue(int valueAtPosition, List<List<int>> after, int i, int j)
        {
            int value = valueAtPosition;

            for (int x = 0; x < i+1; x++)
            {
                for (int y = 0; y < j+1; y++)
                {
                    value -= after[x][y];
                }
            }

            return value;
        }
    }
}
