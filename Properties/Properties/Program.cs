﻿using System;

namespace Properties
{
    class Program
    {

        class Person
        {
            public string Name
            {
                get; set;
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);
        }
    }
}
