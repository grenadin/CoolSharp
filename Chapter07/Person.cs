using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Person
    {
        string name;
        int age; 

         string surname;
         bool gender;
         string nationality;

      

        public int Age { get => Age1; set => Age1 = value; }
        public string Name { get => name; set => name = value; }
        public int Age1 { get => age; set => age = value; }
        public string Surname { get => surname; set => surname = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Nationality { get => nationality; set => nationality = value; }

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
            Console.WriteLine($"Sentence..."+sentence);
        }


       
        

        

      


    }
}
