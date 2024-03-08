using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"Red is a color", "Paper is made out of wood", "Cars are made from air"};
      bool[] answers = {true,true,false};
      bool[] responses = new bool[questions.Length];

      //Checks for possible problems
      if(questions.Length != answers.Length){
        Console.WriteLine("Warning questions and answers are not aligned!");
      }

      int askingIndex = 0;
      foreach(string q in questions)
      {
        // Userinput
        Console.WriteLine(q);
        Console.WriteLine("True of false?");
        string input = Console.ReadLine().ToLower();

        //Checking for correct answer
        bool isBool;
        bool inputBool = Boolean.TryParse(input, out isBool);
        

        //loop to gurantee a acceptable answer
        while(!isBool)
        {
          if(input == "false")  //the output of isBool will only give me a either a true or false. So whenever i have a false i need to make sure the false can also be processed. I didnt knew this because i thought the out is outputting true depending if its a boolean. But after further research i understood it's meant for outputting a result.
          {
            isBool = true;
            break;
          }
          Console.WriteLine("Please respond with 'true' or 'false'.");
          input = Console.ReadLine().ToLower();
          isBool = Boolean.TryParse(input, out isBool);
        }
        
        // saving input and increment index 
        responses[askingIndex] = inputBool;
        askingIndex++;
      }
      
      // Console.WriteLine(responses[0]);
      // Console.WriteLine(responses[1]);
      // Console.WriteLine(responses[2]);

      //15. scoring system
      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers)
      {
        Console.WriteLine($"Input: {responses[scoringIndex]} | Answer: {answers[scoringIndex]}");
        if(responses[scoringIndex] == answers[scoringIndex])
        {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {answers.Length} correct!");

    }
  }
}
