using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
        // type name  new object
         Car myCar = new Car();

          myCar.color = "black";
          myCar.isConvertable = false;
          myCar.make = "POS";
          myCar.model = "very POS";
          myCar.year = 2010; 

          Console.WriteLine(myCar.color + " " + myCar.model);
          
       }
    }
}
