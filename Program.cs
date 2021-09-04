using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
        // type name  new object
        Car myCar = new Car("black", "nissan", "gtr", 2001);

        myCar.Paint("Purple");

        Console.WriteLine(myCar.color);

        // if statements 
        int randNumber = 5;

        if (randNumber > 4)
        {
          System.Console.WriteLine("higher");
        }
        else if (randNumber < 6)
        {
          System.Console.WriteLine("less");
        }
        else
        {
          System.Console.WriteLine("This is it");
        }

      } 
    }
}
