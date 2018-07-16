using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayCopyExcercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] firstArray = { 1, 2, 3, 4, 5 };
            int[] secondArray = new int[5];

            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }



            Console.Write("first array = ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write( firstArray[i] + ", ");
            }


            Console.WriteLine("");
            Console.Write( "second array = ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(  secondArray[i] + ", ");
            }



            Console.ReadLine();
        }
    }
}
