using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] sArray = new string[] { "Joe", "Bob", "Sarah", "Jim", "Joe" };

            Console.WriteLine("With the HashSet1:");
            //With hashset you can cast array into a hashset
            HashSet<string> hSet = new HashSet<string>(sArray);

            //The list will print without repeated values due to 
            //hashset not allowing duplicates, only unique values
            foreach (var item in hSet)
            {
                Console.WriteLine(item);
            }

            string[] sArray2 = new string[] { "Joe", "Jack", "Tim", "John" };
            HashSet<string> hSet2 = new HashSet<string>(sArray2);
            Console.WriteLine("_____________________________");
            Console.WriteLine("With the hashset2");
            foreach (var item in hSet2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("____________________________");
            Console.WriteLine("Presents Hashset 1 with Hashset 2, using the union method");
            //Notice that the hashset remains true to unique values
            hSet.UnionWith(hSet2);

            foreach (var item in hSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_____________________________");
            Console.WriteLine("Using ExceptWith(hSet2) on previously unioned");
            hSet.ExceptWith(hSet2);

            foreach (var item in hSet)
            {
                Console.WriteLine(item);
            }


            HashSet<string> hSet3 = new HashSet<string>(sArray);
            //Using the symmetric except with with not leave one like value, but remove it completely
            hSet3.SymmetricExceptWith(hSet2);
            Console.WriteLine("__________________________");
            Console.WriteLine("Using SymmetricExceptWith on Hashset 1 and Hashset 2");
            foreach (var item in hSet3)
            {
                Console.WriteLine(item);
            }
            */
            //int[] nums = new int[] { 1, 3, 6, 9 };
            //Console.WriteLine(Sumof(7, nums));

            Console.WriteLine(Fib(6));
            
        }
        public static bool Sumof(int sum, int [] arr)
        {
            HashSet<int> hs = new HashSet<int>();   
            int curr = 0;
            
            while (curr <= arr.Length-1)
            {
                 hs.Add(sum - arr[curr]);
                if(hs.Contains(arr[curr]))
                {
                    return true;
                }
                curr++;         
            }
            return false;
        }

        public static int Fib(int pos)
        {
            int last = 0;
            int current = 1;
            int next = 0;
            int tracker = 2;

            if (pos < 2)
                return pos;
            while(tracker <= pos)
            {
                next = current + last;
                last = current;
                current = next;
                tracker++;
            }
            return current;
        }

    }
}
