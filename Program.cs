using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch2PrepExercises
{
    class Program
    {
        public static void Main()
        {
            List<int> numList = new List<int>{ 4, 3, 2, 1, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(EvenListMaker.EvenList(numList));
            //EvenListMaker.EvenList(numList);
            Console.ReadLine();
        }
            
    }
}
