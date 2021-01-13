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

      Console.Write("Please input a superhero");
      string superhero = Console.ReadLine();

      Console.Write("Please input and animal");
      string animal = Console.ReadLine();

      Console.Write("Please input a fruit");
      string fruit = Console.ReadLine();

      Console.Write("Please input a country");
      string country = Console.ReadLine();

      Console.Write("Please input a dessert");
      string dessert = Console.ReadLine();

      Console.Write("Please input a year");
      string year = Console.ReadLine();





      // The template for the story:
      Console.WriteLine("Mad Libs has started");
      string story = $ "This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      // Print the story:
      Console.WriteLine(story);
    }
  }
}