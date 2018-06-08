using System;


namespace Chapter10
{
    




    class Program
    {
        static void Main(string[] args)
        {
            #region base derived
            //Base myBase = new Base();


            //Derived myDerived = new Derived();


            //Base myTest = new Derived();

            //Console.WriteLine($"{myBase.Meth1()} call Meth1() from Base Class" );
            //Console.WriteLine($"{myBase.Meth2()} call Meth2() from Base Class");
            //Console.WriteLine($"{myBase.Meth3()} call Meth3() from Base Class");
            //Console.WriteLine($"{myBase.Meth4()} call Meth4() from Base Class");
            //Console.WriteLine("----------------------------------------------------------------------------");
            //Console.WriteLine($"{myDerived.Meth1()} call Meth1() from Derived Class");
            //Console.WriteLine($"{myDerived.Meth2()} call Meth2() from Derived Class but hide Base Function"); 
            //Console.WriteLine($"{myDerived.Meth3()} call Meth3() from Derived Class don't use new keyword");
            //Console.WriteLine($"{myDerived.Meth4()} call Meth3() from Derived Class don't use new keyword");
            //Console.WriteLine("----------------------------------------------------------------------------");
            //Console.WriteLine($"{myTest.Meth1()} call Meth1() but call from Derived ");
            //Console.WriteLine($"{myTest.Meth2()} call Meth2() but call from Base ");
            //Console.WriteLine($"{myTest.Meth3()} call Meth3() but call from Base");
            //Console.WriteLine($"{myTest.Meth4()} call Meth4() but call from Base");


            //myDerived.t();
            #endregion

            //Animal MyPet = new StBernard();
            //MyPet.Say();

            //MyPet = new Dog();

            //MyPet.Say();

            //MyPet.Age = 5;

            //Console.WriteLine(MyPet.Age);


            //Animal MyPet = new Dog();
            //MyPet.Say(new StBernard());


            //Test[] myTest;
            //myTest = new Test[10];

            //for (int i = 0; i < 4; i++)

            //myTest[i] = new Test();

            //myTest[0].S = "aaa";
            //myTest[1].S = "bbb";
            //myTest[2].S = "ccc";
            //myTest[3].S = "ddd";

            //for (int i = 0; i < 4; i++)
            //Console.WriteLine(myTest[i].S);

            //Console.Beep(500, 6000);

            //Console.Title = "hi";
            //Console.ReadLine();

            

            Cat myCat = new PersianCat();
            Cat cat = new Cat();
            DogHouse dh = new DogHouse();
            Dog[] myDog = new Dog[3];
            myDog[0] = new StBernard();
            myDog[1] = new ChowChow();
            myDog[2] = new Terrier();

            
                dh.Welcome(myDog[0]);
                dh.Welcome(myCat);
            dh.Welcome(cat);


            //dh.Welcome(myCat);

            //dh.Welcome((ISwimmable)myDog[1]);
            //dh.Welcome((ISwimmable)myCat);
            

            //((ISwimmable)myDog[1]).Swim();

            
            
            Console.ReadLine();


            
        




        }
    }
}
