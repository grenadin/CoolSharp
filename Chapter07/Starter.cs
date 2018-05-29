using System;


namespace Chapter07
{
    class Starter
    {
        public static void Main(string[] args)
        {

            Person me = new Person {name="hhh" };
            
            




            Console.WriteLine($"{me.name} {me.age} {me.surname}");


            #region page 209

            //Person me = new Person("Harirak", "Sritham");
            //Person you = new Person("Visava", "aum");
            //Console.WriteLine($"{me.name} " + $"{me.surname}");

            #endregion


            #region page 201


            //Person me = new Person();
            //Person me2 = new Person();
            //Person me3;
            //me.name = "toon";
            //me.Talk("hello");

            #endregion



        }
    }
}



