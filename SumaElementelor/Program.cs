using System;

namespace SumaElementelor
{
    class Program
    {   
        public int Suma(int[] array,int n)
        {
            if (n == 0)
                return 0;
            else
             return array[n] + Suma(array[n - 1]);
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cate numei vrei sa citesti de la tastatura? ");
            int nrElements = int.Parse(Console.ReadLine());
            int[] array = new int[nrElements];

            for (int i = 0; i < nrElements; i++)
            {
                Console.Write($"The {i + 1}. element = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nrElements; i++)
            {
                Console.Write(array[i] + " ");
            }
           
        }
       
    }
}
