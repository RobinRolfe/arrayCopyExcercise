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
            
            int[] firstArray = { 1, 2, 3, 4, 5 };//Declare an arrays with values
            int[] secondArray = new int[5];////Declare an empty array
            
            
            //copy the array using a for loop
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }


            //Display the results
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
