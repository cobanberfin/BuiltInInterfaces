using System;

namespace LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Computer computer = new Computer();
            computer.Disk = new Computer();
            computer.Disk = new SSD();

        }
    }
}
