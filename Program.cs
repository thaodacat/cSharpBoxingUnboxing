using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Boxing();
        }

        static void Boxing()
        {
            List<object> theList = new List<object>();
            // Console.WriteLine(String.Join(", ", theList));

            theList.Add(7);
            theList.Add(28);
            theList.Add(-1);
            theList.Add(true);
            theList.Add("chair");
            // Console.WriteLine(String.Join(", ", theList));

            foreach(var i in theList)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            foreach(var i in theList)
            {
                if(i is int)
                {
                    sum += (int)i;
                }

            }
            Console.WriteLine($"Sum is {sum}");
        }
    }
}
