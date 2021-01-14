using System;

namespace Destructor
{
    class Program
    {
        class Dog
        {
            public Dog()
            {
                Console.WriteLine("constructor");
            }
            ~Dog()
            {
                Console.WriteLine("destructor");
            }
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}
