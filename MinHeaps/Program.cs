using System;

namespace MinHeaps
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxHeap<int> mm = new MaxHeap<int>()
            {
                5,8,9,45,1,5,4,2,-2
            };

            Console.WriteLine("Root :" + mm.Root);

            while (true)
            {
                try
                {
                    Console.WriteLine("移除：" + mm.Extract());
                }
                catch
                {
                    break;
                }
            }
        }




    }
}
