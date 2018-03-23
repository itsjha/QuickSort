//C# program for Quick-Sort

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuickSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] inputArray = { 5, 3, 6, 4, 2, 5, 7, 8, 3, 1, 9, 1, 8, 7 };
            QuickSort(inputArray);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i]+"  ");
            }
            Console.ReadKey();
        }
        static void QuickSort(int[] inputArray)
        {
            QuickSort(inputArray, 0, inputArray.Length - 1);
        }

        static void QuickSort(int[] inputArray, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = inputArray[start];

            int startingPointer = start, endPointer = end;

            while (startingPointer < endPointer)
            {
                while (startingPointer < endPointer && inputArray[endPointer] >= num)
                {
                    endPointer--;
                }

                inputArray[startingPointer] = inputArray[endPointer];

                while (startingPointer < endPointer && inputArray[startingPointer] < num)
                {
                    startingPointer++;
                }

                inputArray[endPointer] = inputArray[startingPointer];
            }

            inputArray[startingPointer] = num;
            QuickSort(inputArray, start, startingPointer - 1);
            QuickSort(inputArray, startingPointer + 1, end);
        }

    }
}
