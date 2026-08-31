using System;
    // Base Class
    public class Animal
    {
        // Virtual method allows derived classes to override it
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived Class: Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived Class: Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class InheritanceDemo
    {
        public static void Run()
        {
            Console.WriteLine("--- Task 1: Inheritance & Method Overriding ---");

            Animal genericAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            genericAnimal.MakeSound();
            myDog.MakeSound();
            myCat.MakeSound();

            Console.WriteLine();
        }
    }

