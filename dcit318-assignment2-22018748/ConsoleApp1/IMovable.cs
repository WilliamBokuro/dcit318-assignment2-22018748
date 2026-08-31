using System;
    // Interface Definition
    public interface IMovable
    {
        void Move();
    }

    // Class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class InterfaceDemo
    {
        public static void Run()
        {
            Console.WriteLine("--- Task 3: Interfaces ---");

            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move();
            myBicycle.Move();

            Console.WriteLine();
        }
    }
