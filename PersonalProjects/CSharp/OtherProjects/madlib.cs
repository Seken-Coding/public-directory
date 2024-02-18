using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program ... 
      requires input from the user to fill out a prewritten text with gaps.
      Author: ...
      Codecademy + Alex Chong
      */


      // Let the user know that the program is starting:
      Console.WriteLine("The madlib is starting.");

      // Give the Mad Lib a title:
      string title = "The crazy madlib";

      Console.WriteLine(title);
      // Define user input and variables:

      //  Name
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      // Adjectives
      Console.Write("Enter a adjectives: ");
      string adj1 = Console.ReadLine();
      Console.Write("Enter a adjectives: ");
      string adj2 = Console.ReadLine();
      Console.Write("Enter a adjectives: ");
      string adj3 = Console.ReadLine();

      //  Verb
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      //  Nouns
      Console.Write("Enter a noun: ");
      string noun1 = Console.ReadLine();
      Console.Write("Enter a noun: ");
      string noun2 = Console.ReadLine();

      //  Random inputs
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.Write("Enter a food: ");
      string food = Console.ReadLine();
      Console.Write("Enter an fruit: ");
      string fruit = Console.ReadLine();
      Console.Write("Enter an superhero: ");
      string superhero = Console.ReadLine();
      Console.Write("Enter an country: ");
      string country = Console.ReadLine();
      Console.Write("Enter an dessert: ");
      string dessert = Console.ReadLine();
      Console.Write("Enter an year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
