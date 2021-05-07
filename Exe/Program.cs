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
      SecondQ(session, tutorialIdx, "");

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
    public static void SecondQ(Sesh session, int tutorialIdx, string lastInput)
    {
      var tutorialMessages = new string[]
      {
        "Type 'BREAD' for BREAD, or 'PASTRY' for PASTRY.",
        "By the way, just type a number if you'd like multiple of something.",
        "Also, you can repeat your last request with the enter key."
      };
      if (tutorialIdx >= 0 && tutorialIdx < tutorialMessages.Length)
      {
        Console.WriteLine(tutorialMessages[tutorialIdx]);
      }
      try
      {
        string userInput = Console.ReadLine();
        if (userInput == "" & lastInput != "") userInput = lastInput;
        lastInput = userInput;
        switch (userInput)
        {
          case "OK":
            Console.WriteLine("I said 'BREAD' or 'PASTRY'");
            throw new();
          case "bread":
            Console.WriteLine("I'm hard of hearing, son, please speak up.");
            throw new();
          case "pastry":
            Console.WriteLine("What was that? Did you say 'PAISLEY'?");
            throw new();
          case "PAISELY":
            Console.WriteLine("We don't have PAISELY here.");
            throw new();
          case "BREAD":
            session.Add(new Bread());
            break;
          case "PASTRY":
            session.Add(new Pastry());
            break;
          default:
            try
            {
              int number = int.Parse(userInput);
              Console.WriteLine($"What do you want {number} of?");
              userInput = Console.ReadLine();
              if (number > 100)
              {
                Console.WriteLine($"That's a lot of {userInput}!");
              }
              switch (userInput)
              {
                case "BREAD":
                  while (number > 0)
                  {
                    session.Add(new Bread());
                    number--;
                  }
                  break;
                case "PASTRY":
                  while (number > 0)
                  {
                    session.Add(new Pastry());
                    number--;
                  }
                  break;
                default: throw new();
              }
            }
            catch (Exception)
            {
              Console.WriteLine("But we don't have that here.");
              throw;
            }
            break;
        }
      }
      catch (Exception)
      {
        SecondQ(session, -1, "");
      }
      int breadCount = session.Order.Where(bg => bg.GetType().Name == "Bread").Count();
      int pastryCount = session.Order.Where(bg => bg.GetType().Name == "Pastry").Count();
      Console.WriteLine($"order: {breadCount} BREAD / {pastryCount} PASTRY.");
      Console.WriteLine($"subtotal: ${session.Subtotal}");
      tutorialIdx++;
      SecondQ(session, tutorialIdx, lastInput);
    }

  }
}