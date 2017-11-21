using System;
using System.Collections.Generic;

namespace bootcamp_21_11_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 5;

            Console.WriteLine($"num1: {num1} , num2: {num2}");

            Utilities.Swap(ref num1,ref num2);
            Console.WriteLine($"num1: {num1} , num2: {num2}");

            string d1 = "left";
            string d2 = "right";
            Console.WriteLine($"d1: {d1} , d2: {d2}");

            Utilities.Swap(ref d1, ref d2);
            Console.WriteLine($"d1: {d1} , d2: {d2}");

            Console.WriteLine("-----------------");
            List<int> list1 = new List<int> { 5, 2, 2, 2, 6, 6, 2, 2, 4, 4, 6, 6, 6, 6, 6, 6, 7,7,4,7,7,7,7,7, 2, 4, 10, 10, 10, 10, 10 };
            Utilities.PrintList(list1);

            List<int> newList1 = Utilities.SubSeq(list1);
            Utilities.PrintList(newList1);

            Console.WriteLine("-----------------");
            List<string> list2 = new List<string>
            { "game",
              "set",
              "match",
              "park",
              "park",
              "park",
              "get",
              "a","a","b","a","a","a"
            };
            Utilities.PrintList(list2);

            List<string> newList2 = list2.SubSeq() ;
            Utilities.PrintList(newList2);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
