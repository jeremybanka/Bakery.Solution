using System;
using Bakery.Models;

namespace Bakery.Executable
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello!");
      string userInput = Console.ReadLine();
      try
      {
        if (userInput == "Hello!") Console.WriteLine("Nice to see you!");
        else throw new ArgumentException("Well that wasn't very nice.");
      }
      catch (ArgumentException e)
      {
        Console.WriteLine(e);
        Main();
      }
    }
  }
}