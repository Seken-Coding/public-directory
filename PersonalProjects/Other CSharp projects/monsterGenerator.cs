using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {


      startingMode();
      //summarized methods
      // instead of calling every method once
      //BuildACreature("ghost","ghost","ghost");

      
      //random generated 
      //RandomMode();

      //shorten method
      //SwitchCase(1,1,1);
    }
    static void startingMode(){
      Console.WriteLine("Type 1 for a generated monster | Type 2 for a custom monster: ");
      int userChoice = Convert.ToInt32(Console.ReadLine());
      if(userChoice == 1)
      {
        RandomMode();
      }

      if(userChoice == 2)
      {
        int valueHead;
        int valueBody;
        int valueFeet;
        Console.WriteLine("1 for Ghost, 2 for Monster, 3 for Bug");
        Console.WriteLine("What head would you like?");
        valueHead = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 for Ghost, 2 for Monster, 3 for Bug");
        Console.WriteLine("What body would you like?");
        valueBody = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 for Ghost, 2 for Monster, 3 for Bug");
        Console.WriteLine("What feet would you like?");
        valueFeet = Convert.ToInt32(Console.ReadLine());

        SwitchCase(valueHead,valueBody,valueFeet);

      }
      
    }
    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);

      SwitchCase(headNum,bodyNum,feetNum);
    }

    //RandomModule
    static void RandomMode()
    {
      Random randomNumber = new Random();
      int randomHead = randomNumber.Next(1,4);
      int randomBody = randomNumber.Next(1,4);
      int randomFeet = randomNumber.Next(1,4);

      SwitchCase(randomHead,randomBody,randomFeet);
    }
    //Switch case to break down the code
    static void SwitchCase(int head, int body, int feet)
    {
      switch(head)
      {
        case 1:
        GhostHead();
        break;
        case 2:
        MonsterHead();
        break;
        case 3:
        BugHead();
        break;      
      }
      switch(body)
      {
        case 1:
        GhostBody();
        break;
        case 2:
        MonsterBody();
        break;
        case 3:
        BugBody();
        break;        
      }
      switch(feet)
      {
        case 1:
        GhostFeet();
        break;
        case 2:
        MonsterFeet();
        break;
        case 3:
        BugFeet();
        break;
      }
    }

    //Translating the strings to numbers
    static int TranslateToNumber(string creature)
    {
      switch(creature)
      {
        case "ghost":
        return 1;
        case "monster":
        return 2;
        case "bug":
        return 3;
        default:
        return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
