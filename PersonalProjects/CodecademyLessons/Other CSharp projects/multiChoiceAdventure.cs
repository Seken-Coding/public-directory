using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {

      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

      //First choice
      Console.WriteLine("Type YES or NO: ");     
      string noiseChoice = Console.ReadLine().ToUpper();
      if(noiseChoice == "NO"){

        //Game over 1
        Console.WriteLine();
        Console.WriteLine("Not much of an adventure if we don't leave our room! \nTHE END.");
        Console.WriteLine();
      } else if(noiseChoice == "YES"){

        //Second choice
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
        Console.WriteLine("Type OPEN or KNOCK: ");
        string doorChoice = Console.ReadLine().ToUpper();
        if(doorChoice == "KNOCK"){

          //Third choice / riddle
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"Poor people have it. Rich people need it. If you eat it you die. What is it?");
          Console.WriteLine("Type your answer: ");
          string riddleAnswer = Console.ReadLine().ToUpper();
          if(riddleAnswer == "NOTHING"){

            //Game over 2
            Console.WriteLine("The door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock the door. \nTHE END.");
          } else {

            //Game over 3
            Console.WriteLine("You answered incorrectly. The door doesn't open. \nTHE END");
          }
        }else if(doorChoice == "OPEN"){

          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          Console.Write("Enter a number (1-3): ");
          string keyChoice = Console.ReadLine();

          //Switch case for keys
          switch(keyChoice){
            case "1":
            Console.WriteLine("You choose the first key. Lucky choice!\nThe door opens and NOTHING is there. Strange...\nTHE END.");
            break;
            case "2":
            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
            break;
            case "3":
            Console.WriteLine("You choose the third key. The door doesn't open.\nTHE END.");
            break;
            default:
            Console.WriteLine("You cant do this! \nTHE END");
            break;
          }
        }
      }
    }
  }
}



