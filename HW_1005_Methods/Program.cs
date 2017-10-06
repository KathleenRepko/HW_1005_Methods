using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1005_Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            //Problem #1
            //Console.WriteLine(SayHello("Cam"));

            //SayGoodbye("Gracie");

            ////Problem #2 - is this the same as #1?

            ////Problem #3
            //Console.WriteLine("The sum of the two numbers is " + SumIt(8, 4) + ".");

            ////Problem #4
            //int[] example = { 20, 10, 5, 2 };
            //Console.WriteLine("The sum of the example array is " + ArraySum(example) + ".");

            ////Problem #5
            //Console.WriteLine("The doubled integer is " + DoubleIt(15) + ".");

            //Problem #6
            //Create a method called SumDigits that receives a number and returns the sum of its digits. 
            //For example, if the number is 123, the sum would be 6.
            //Inside main should look like this:
            //Console.WriteLine(SumDigits(123));

            //int userNumber = 7123;
            //Console.WriteLine(SumDigits(userNumber));


            //Problem #7
            //Create a method which returns the greatest value stored in an array of numbers which is specified as parameter: 

            int[] data = { 87, 90, 23 };
            Console.WriteLine(FindMaximum(data));



        }



        public static string SayHello(string name)
        {
            string sayHello = ("Hello, " + name + "!");

            return sayHello;
        }
        public static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name + ".");
        }

        public static int SumIt(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;

            return sum;
        }

        public static int ArraySum(int[] example)
        {
            int arraySum = example[0] + example[1] + example[2] + example[3];

            return arraySum;
        }

        public static int DoubleIt(int userNumber)
        {
            int doubledNumber = userNumber * 2;

            return doubledNumber;
        }

        public static int SumDigits(int userNumber)
        {
            int total = 0;
            int remainder = 0;
            while (userNumber != 0)
            {
                remainder = userNumber % 10;
                userNumber = userNumber / 10;
                total = total + remainder;
            }

            return total;

        }

        public static int FindMaximum(int[] data)
        {

            int max = (data.Max());

            return max;
        }

            

    }
}
