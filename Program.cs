using System;

namespace Kickarse_MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is my first MadLibs Game made using C#
             * Author Jordan Heasman */
            string welcomeMessage = "Hello. This is an online game of Madlibs. \n Press Enter to start the game";
            Console.WriteLine(welcomeMessage);
            Console.ReadLine();
            // Let the user know that the program is starting:

            // Give the Mad Lib a title:
            string title = "Jordan's Kickarse Madlibs Game";
            Console.WriteLine($"Let's begin {title}");

            // Define user input and variables:
            Console.WriteLine("Before we start, please tell me your hero's name: ");
            string heroName = Console.ReadLine();
            Console.WriteLine("Thank you.To make this a great story, I will need you to give me some information. \nPlease give me three adjectives to describe our hero's journey. They are words that describe nouns. \nYou should write the first describing word here : ");
            string adjOne = Console.ReadLine();
            Console.WriteLine("A second adjective: ");
            string adjTwo = Console.ReadLine();
            Console.WriteLine("And a third and final adjective: ");
            string adjThree = Console.ReadLine();
            Console.WriteLine("And finally, please give me a \"doing\" word: ");
            string heroVerb = Console.ReadLine();
            // Variables are: heroName / adjOne / adjTwo / adjThree / heroVerb
            Console.WriteLine("Thank you. I will also need from you two nouns to complete our epic tale. A noun is a person place or thing. You may write your first noun here: ");
            string nounOne = Console.ReadLine();
            Console.WriteLine("Excellent choice. And now your second noun: ");
            string nounTwo = Console.ReadLine();
            // Variables are: nounOne / nounTwo
            Console.WriteLine("Great. We are nearly done.\nTo make this a truly excellent game I want you now to write down the first thing you think of in the space after these words: ");
            //List of new variables:
            Console.WriteLine("An animal: ");
            string heroAnimal = Console.ReadLine();
            Console.WriteLine("A food : ");
            string heroFood = Console.ReadLine();
            Console.WriteLine("A fruit : ");
            string heroFruit = Console.ReadLine();
            Console.WriteLine("A superhero : ");
            string heroSuper = Console.ReadLine();
            Console.WriteLine("A country : ");
            string heroCountry = Console.ReadLine();
            Console.WriteLine("A dessert : ");
            string heroDessert = Console.ReadLine();
            Console.WriteLine("A year : ");
            string heroYear = Console.ReadLine();
            // 
            Console.WriteLine("Excellent. I now have all the details for your hero's story. Press enter to continue.");
            Console.ReadLine();

            // The template for the story:

            string story = $"This morning {heroName} woke up feeling {adjOne}. 'It is going to be a {adjTwo} day!'\nOutside, a bunch of {heroAnimal}s were protesting to keep {heroFood} in stores. They began to {heroVerb} to the rhythm of the {nounOne}, which made all the {heroFruit}s very {adjThree}.\nConcerned, {heroName} texted {heroSuper}, who flew {heroName} to {heroCountry} and dropped {heroName} in a puddle of frozen {heroDessert}.\n{heroName} woke up in the year {heroYear}, in a world where {nounTwo}s ruled the world.";
            Console.WriteLine(story);
            Console.ReadLine();
            Console.WriteLine("The End. \n Or is it?....");
            // The end. Or is it?....







        }
    }
}
