using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Execute all three tasks in order
            InheritanceDemo.Run();
            AbstractClassDemo.Run();
            InterfaceDemo.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
