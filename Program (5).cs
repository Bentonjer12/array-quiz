using System;

namespace quizarr
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            //int n = 10;(Part 1 and 2)
            int[] a = new int[100];

            Console.Write("\n\nEnter a number for all 10 elements(or numbers) of the array:\n");
            Console.Write("---------------------------------------------------------------------\n");
            //Enter input(Part 3)
            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            //For loop array(Part 1)
            Console.Write("Input {0} number of elements in the array :\n", n);
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
            /*for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe values stored into the array are : \n");
            foreach (int ii in a)
            {
                Console.Write("{0}  ", ii);
                Console.ReadLine();
            }*/
           
  

        }



    }
}



