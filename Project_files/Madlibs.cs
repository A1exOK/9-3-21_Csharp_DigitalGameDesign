using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
    // Mad Libs Creation Program | Author: Alex Oh \\

      /*
      This program will have the user type in several names, nouns, adjectives, and verbs to make their own madlibs project. 
      */
      
      // Startup Sequence
      Console.WriteLine("Starting Madlibs program... \n");

      // Give the Mad Lib a title:
      string title = " || Alex's Madlibs Program || ";

      Console.WriteLine(title);
      // Define user input and variables: 
      Console.WriteLine("\n Enter a name: ");
      string name1 = Console.ReadLine();

      Console.WriteLine("\n Enter 3 adjectives: ");
      string adj1 = Console.ReadLine();
      string adj2 = Console.ReadLine();
      string adj3 = Console.ReadLine();

      Console.WriteLine("\n Enter a verb: ");
      string verb1 = Console.ReadLine();

      Console.WriteLine("\n Enter 2 nouns: ");
      string noun1 = Console.ReadLine();
      string noun2 = Console.ReadLine();

      Console.WriteLine("\n Enter an animal: ");
      string animal1 = Console.ReadLine();
      
      Console.WriteLine("\n Enter a food & a fruit: ");
      Console.WriteLine("Food: ");
      string food1 = Console.ReadLine();
      Console.WriteLine("Fruit: ");
      string fruit1 = Console.ReadLine();

      Console.WriteLine("\n Enter a superhero: ");
      string superhero1 = Console.ReadLine();

      Console.WriteLine("\n Enter a country: ");
      string country1 = Console.ReadLine();
      
      Console.WriteLine("\n Enter a dessert: ");
      string dessert1 = Console.ReadLine();

      Console.WriteLine("\n Enter a year: ");
      string year1 = Console.ReadLine();

      // The template for the story:
      string story = $"This morning {name1} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal1}s were protesting to keep {food1} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit1}s very {adj3}. Concerned, {name1} texted {superhero1}, who flew {name1} to {country1} and dropped {name1} in a puddle of frozen {dessert1}. {name1} woke up in the year {year1}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}