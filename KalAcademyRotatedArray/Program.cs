using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalAcademyRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 5, 6, 7, 8, 9, 10, 1, 2 };
            int n = myArray.Length;
            int key = 9;
            Console.WriteLine("The number you want is " + RotatedArray(myArray, 0, n-1, key));
            Console.ReadLine();
        }
        public static int RotatedArray(int[] myArray, int low, int hi, int key)
        {
            if (low > hi)
                return -1;

            int mid = (low + hi) / 2;

            if (key == myArray[mid])
                return mid;
            if (key > myArray[mid])
                return RotatedArray(myArray, (mid + 1), hi, key);
            return RotatedArray(myArray, low, (mid - 1), key);
        }
    }
}
