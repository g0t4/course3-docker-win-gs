using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace FooService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("environment:");
            Console.WriteLine($"  OS: {RuntimeInformation.OSDescription}");
            Console.WriteLine($"  Fwk: {RuntimeInformation.FrameworkDescription}");
            Console.WriteLine();

            Console.WriteLine("initializing Foo service...");
            Thread.Sleep(1000);
            
            Console.WriteLine("running...");
            Thread.Sleep(3000);
        }
    }
}
