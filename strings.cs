using System; 

namespace MyName
{
  public class String
  {
    public void Strings()
    {
      Console.WriteLine("Hello World!");
      string myFavoriteAnime = "Rouroni Kenshin";

      // to grabe the index of a char in the string use; 
      char firstLetter = myFavoriteAnime[0];


      // string concatination is done with 
      string firstName = "Kenshin";
      string lastName = "Himura";

      string fullName = firstName + ' ' + lastName;

      // the command to write something to the terminal is console.writeline

      Console.WriteLine(fullName);
    }
  }
}