using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {

      // Let the user know that the program is starting:


      // Give the Mad Lib a title:
      string title = "TITLE";

      Console.WriteLine(title);
      // Story variable are here
      Console.Write("Enter a name: ");
      string name = Console.Readline();

      Console.Write("State an adjective: ");
      string adj1 = Console.ReadLine();

      Console.Write("State a second adjective: ");
      string adj2 = Console.ReadLine();

      Console.Write("State a third adjective: ");
      string adj3 = Console.ReadLine();

      Console.Write("State a verb: ");
      string verb = Console.ReadLine();

      Console.Write("State a noun: ");
      string noun1 = Console.ReadLine();

      Console.Write("State a second noun: ");
      string noun2 = Console.ReadLine();

      Console.Write("Please state a superhero");
      string superhero = Console.ReadLine();

      



      // The template for the story:
      Console.WriteLine("Mad Libs has started");
      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}