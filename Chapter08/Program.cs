using System;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            NokiaPhone myMobile = new NokiaPhone("8350", "silver", true);

            myMobile.Mask = "gold"; // this line set new mask. *** !beware this!! when call propertie it take action automatically

            NokiaPhone yourMobile = new NokiaPhone("8800", "red");
            yourMobile.Mask = "gold"; // this line set new mask. *** ! beware this!! when call propertie it take action automatically



            ObjectInitializer Objinit = new ObjectInitializer { Home_number="12/12", Building ="VTUW"};
           
           
            Console.WriteLine(Objinit.Building);
            Objinit.Building = "VTUI";
            Console.WriteLine(Objinit.Building);
            Console.ReadLine();


           






        }
    }
}
