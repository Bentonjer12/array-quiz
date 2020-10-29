using System;

namespace quizarr
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i;
            //int n = 10; //(Part 1 and 2)
            //Console.Write("\n\nEnter a number for all 10 elements(or numbers) of the array:\n");
            //Console.Write("---------------------------------------------------------------------\n");

            //Enter input(Part 3)
            int i,n;
            Console.Write("Input the number of elements to store in the array :");   
            n = Convert.ToInt32(Console.ReadLine());
            
            //Creating the Array
            int[] a = new int[n];
            
            //For loop array(Part 1+Part 3)
            Console.Write($"Input {n} elements to input into the array :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values stored into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
                Console.ReadLine();
            }
            //You have to press enter after each interation!!

            //Foreach loop array(Part 2)
            /* for (i = 0; i < n; i++)
             {
                 Console.Write("element - {0} : ", i);
                 a[i] = Convert.ToInt32(Console.ReadLine());
             }
             Console.Write("\nThe values stored into the array are : \n");
             foreach (int ii in a)
             {
                 Console.Write("{0}  ", ii);
                 Console.ReadLine();
             }
            */
        }
    }
}



