using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT213_Key_Unit8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define an integer array that will hold 10 integers. Initialize it with 10 given values.
            int[] numberArray = { 56, 77, 23, 12, 88, 59, 97, 33, 38, 64 };

            //Define an array that holds 10 strings
            String[] stringArray = new String[10];

            int numberArrayLength = numberArray.Length;

            int maxNumber = numberArray[findMax(numberArray, numberArrayLength)];
            evenOrOdd(numberArray, stringArray, numberArrayLength);

            //print the maximum number determined by findMax as well as the array index position of the largest number
            Console.WriteLine("The numbers were:");
            for (int i = 0; i < numberArrayLength; i++)
                Console.WriteLine(numberArray[i] + " is " + stringArray[i]);

            //keep the console window open
            Console.Read();
        }

        //Write a function, named findMax, that will accept two arguments and return an integer value.
        //The first parameter is an integer array. The second parameter is the size or length of the integer array
        public static int findMax(int[] arg1, int arg2)
        {
            int maxValue = arg1[0];
            int maxValuePosition = 0;

            //loop through the positions in the array, searching all items to find the largest value in the array
            for (int i=0; i < arg2; i++)
            {
                if (arg1[i] > maxValue)
                {
                    maxValue = arg1[i];
                    maxValuePosition = i;
                }
            }
            return maxValuePosition;
        }

        //evenOrOdd functino
        //First parameter is the integer array
        //Second parameter is the string array
        //Third parameter is an integer indicating the size of the two arrays
        public static String[] evenOrOdd(int[] arg1, String[] arg2, int arg3)
        {
            //loop through the first array, checking to see if value is odd or even
            for (int i = 0; i < arg3; i++)
            {
                //Assign odd or even second array
                if (arg1[i] % 2 == 0)
                {
                    arg2[i] = "even";
                }
                else
                {
                    arg2[i] = "odd";
                }
            }
            return arg2;
        }
    }
}//end of program