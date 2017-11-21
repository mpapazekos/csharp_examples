using System;
using System.Collections.Generic;
using System.Text;

namespace bootcamp_21_11_2017
{
    public static class Utilities
    {
        
        public static void Swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static void Swap<T>(ref T a,ref T b)
        {
            T temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static List<int> SubSeq(this List<int> theList)
        {
            int max = 1;
            int pos = 0;

            for (int i = 0; i < theList.Count - 1; i++)
            {
                int tempMax = 1;

                while (theList[i + 1] == theList[i])
                {
                    tempMax++;
                    i++;

                    if(i == theList.Count - 1)
                    {
                        break;
                    }
                }

                if (tempMax > max)
                {
                    max = tempMax;
                    pos = i;
                }            
            }

            List<int> results = new List<int>();

            while (max > 0)
            {
                results.Add(theList[pos]);
                max--;
            }

            return results;
        }


        public static List<T> SubSeq<T>(this List<T> theList)
        {
            int max = 1;
            int pos = 0;

            for (int i = 0; i < theList.Count - 1; i++)
            {
                int tempMax = 1;

                while (theList[i + 1].Equals(theList[i]))
                {
                    tempMax++;
                    i++;

                    if (i == theList.Count - 1)
                    {
                        break;
                    }
                }

                if (tempMax > max)
                {
                    max = tempMax;
                    pos = i;
                }
            }

            List<T> results = new List<T>();

            while (max > 0)
            {
                results.Add(theList[pos]);
                max--;
            }

            return results;
        }


        public static void PrintList<T>(List<T> theList)
        {
            foreach(var item in theList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n-----------------");
        }
        
    }
}
