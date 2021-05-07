using System;
using System.Linq;
using Bakery.Models;

namespace Bakery.Executable
{
  public class Program
  {
    public static void Main()
    {
      Sesh session = new();
      Console.WriteLine("Hello! And welcome to Pierre's Bakery.");
      Console.WriteLine("At this bakery, we make BREAD ($5) and PASTRY ($2).");
      Console.WriteLine("Type 'OK' if you understand.");
      Console.WriteLine("Type 'MORE' if you would like to know more.");
      FirstQ();
      int tutorialIdx = 0;
    }
    public static void FirstQ()
    {
      try
      {
        string userInput = Console.ReadLine();
        switch (userInput)
        {
          case "OK":
            Console.WriteLine("Great. So what do you want?");
            break;
          case "MORE":
            Console.WriteLine("Buying 2 BREAD makes the third BREAD free!");
            Console.WriteLine("And 3 PASTRY would normally be $6. But just for you, it's $5.");
            break;
          default: throw new();
        }

      }
      catch (ArgumentException)
      {
        Console.WriteLine("You gotta work with me here, bud.");
        FirstQ();
      }
    }
  }
}