using System;

namespace _11.LinkedList
{
    class TestList
    {
        static void Main()
        {
            LinkedList<int> someList = new LinkedList<int>();
            someList.AddFirst(32);
            someList.AddFirst(443);
            someList.AddFirst(23);
            someList.AddFirst(111);
            someList.AddLast(1211);

            Console.WriteLine(someList.Count());

            someList.Remove(23);

            someList.PrintList();
        }
    }
}
