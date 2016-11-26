using System;

namespace MinHeaps
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> mm = new MinHeap<int>()
            {
                5,8,9,45,1,5,4,2,-2
            };

            Console.WriteLine("Root :" + mm.Root);
            Console.WriteLine("移除? :" + mm.Remove(0));

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
            Console.WriteLine("剩余：" + mm.Count);
        }




    }
}
