using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Person
    {
        public string name, surname;
        public bool gender;
        public int age;
        public string nationality;

        public void Walk()
        {
            Console.WriteLine("Walk...");
        }

        public void Run()
        {
            Console.WriteLine("Run...");
        }

        public void Talk(string sentence)
        {
            Console.WriteLine($"Say...{sentence}");
        }


    }
}
