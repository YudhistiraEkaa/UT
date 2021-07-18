using System;

namespace Aerox
{
    class Program
    {
        public static void lantai1(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }

        public static void lantai2(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }

        public static void lantai3(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }

        public static void lantai4(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }

        public static void lantai5(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }

        public static void lantai6(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + "");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            lantai1(1, 2, 3, 4, 5);
            lantai2(6, 7, 8, 9, 10, 11);
            lantai3(12, 13, 14, 15, 16, 17, 18);
            lantai4(19, 20, 21, 22, 23);
            lantai5(24, 25, 26, 27, 28, 29);
            lantai6(30, 31, 32, 33, 34, 35, 36);
        }
    }
}
