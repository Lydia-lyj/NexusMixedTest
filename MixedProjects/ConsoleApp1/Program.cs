using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {

        [DllImport("PROJECT5.dll", EntryPoint = "TheAdd", CallingConvention = CallingConvention.Cdecl)]
        public static extern int TheAdd(int a, int b);
        static void Main(string[] args)
        {
            var a = TheAdd(2,1);
            Console.WriteLine("Hello World!");
        }
    }
}
