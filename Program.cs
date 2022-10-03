using System;
using System.Linq;
using System.Collections.Generic;

 class dk
{

    static void Main(string[] args)
    {

         List<int> my = new List<int>() { 78, 460, 780, 890, 303, 170 };
        {
           // string[] my = new string[] { "Aman", "Raman", "Shyam", "Aditya" };

            var raja = from w in my
                       orderby w
                       select w;


            Console.WriteLine("Sorted in Ascending order by length:");
            foreach (int value in raja)
            {
                Console.Write(value + " ");
            }
        }
    }
}