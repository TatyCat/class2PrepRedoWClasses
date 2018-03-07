using System;
using System.Collections.Generic;
using System.Text;

namespace Ch2PrepExercises
{
    class EvenListMaker
    {
        public static string EvenList(List<int> numList)
        {
            //running vic solution, replace string with void 
            List<int> allEven = new List<int>();

            //List<int> results = numList.FindAll(number => number % 2 == 0);
            //results.ForEach(result => Console.WriteLine(result));

            foreach (int numb in numList)
            {
                if (numb % 2 == 0)
                {
                    allEven.Add(numb);
                }

            }

            string evenNumbString = string.Join(",", allEven.ToArray());

            return evenNumbString;
        }

    }
}
