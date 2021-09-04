using System; 

namespace C_ 
{
  public class Car
  {
    // declaring the variables 
    public string make;
    public string model;
    public int year;
    public string color;
    public bool isConvertable;

    // constructor 
    // constructor is a method that is called when the class is instantiated. 
    public Car(string color , string make, string model, int year)
    {
      this.color = color;
      this.model = model;
      this.make = make;
      this.year = year; 
      isConvertable = false; 
    }

    //member methods
    public void Paint(string color)
    {
      this.color = color;
    }
  }  
}