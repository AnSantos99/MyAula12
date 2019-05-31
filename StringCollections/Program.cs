using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "Night";
            string c = "Day";
            string d = "Hello";
            string e = "beach";

            
            Stack<string> stackList = new Stack<string>();
            Queue<string> queueList = new Queue<string>();
            HashSet<string> hashSetList = new HashSet<string>();
            List<string> strList = new List<string> { a, b, c, d, e };


            // stack
            stackList.Push(a);
            stackList.Push(b);
            stackList.Push(c);
            stackList.Push(d);
            stackList.Push(e);

            // Queue
            queueList.Enqueue(a);
            queueList.Enqueue(b);
            queueList.Enqueue(c);
            queueList.Enqueue(d);
            queueList.Enqueue(e);

            // Hashset
            hashSetList.Add(a);
            hashSetList.Add(b);
            hashSetList.Add(c);
            hashSetList.Add(d);
            hashSetList.Add(e);

            Console.WriteLine("-----List-----");
            foreach (string i in strList)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine();

            Console.WriteLine("-----Stack-----");
            foreach (string i in stackList)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine();

            Console.WriteLine("-----Queue-----");
            foreach (string i in queueList)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine();

            Console.WriteLine("-----HashSet-----");
            foreach (string i in hashSetList)
            {
                Console.WriteLine(i);
                
            }

            Console.WriteLine();
            



        }
    }
}
